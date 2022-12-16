using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Services
{
    public class MagazineService: IMagazineService 
    {
        private readonly IDAL dal;

        private User uLog = null;

        public MagazineService(IDAL dal)
        {
            this.dal = dal;
        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }

        public void DBInitialization()
        {
            RemoveAllData();

            User u1 = new User("1234", "Pepe", "TheBoss", false, "ninguna", "ptheboss@gmail.com", "theboss", "1234");
            AddUser(u1);

            Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista Universitaria", u1);
            AddMagazine(m);

            User u2 = new User("2345", "Javier", "Garcia", false, "la mia", "jgarcia@gmail.com", "jgarcia", "1234");
            AddUser(u2);
            Area a1 = new Area("Area 1", u2, m);
            AddArea(a1);

            User u3 = new User("3456", "Mª Carmen", "Jimenez", false, "la mia por supuesto", "mcjimenez@gmail.com", "mcjimenez", "1234");
            AddUser(u3);
            Area a2 = new Area("Area 2", u3, m);
            AddArea(a2);

            // De regalo
            User u4 = new User("4567", "Juan", "Campeador", false, "la mejor", "jcampeador@gmail.com", "jcampeador", "1234");
            AddUser(u4);
        }

        public void AddPerson(Person person)
        {
            // Restricción: No puede haber dos personas con el mismo DNI
            if (dal.GetById<Person>(person.Id) == null)
            {
                dal.Insert<Person>(person);
                dal.Commit();
            } 
            else throw new ServiceException("Person with Id " + person.Id + " already exists.");
        }

        public void AddMagazine(Magazine.Entities.Magazine magazine)
        {
            // Restricción: No puede haber dos revistas con el mismo nombre
            if (!dal.GetWhere<Magazine.Entities.Magazine>(x => x.Name == magazine.Name).Any())
            {
                dal.Insert<Magazine.Entities.Magazine>(magazine);
                dal.Commit();
            }
            else throw new ServiceException("Magazine with name " + magazine.Name + " already exists.");
        }

        public void AddArea(Area area)
        {
            // Restricción: No puede haber dos areas con el mismo nombre
            if (!dal.GetWhere<Area>(x => x.Name == area.Name).Any())
            {
                dal.Insert<Area>(area);
                dal.Commit();
            }
            else throw new ServiceException("Area with name " + area.Name + " already exists.");
        }

        // A partid de aquí escribid vuestras implementaciones
        public void AddUser(User u)
        {
            // Restricción: No puede haber dos areas con el mismo nombre
            if (!dal.GetWhere<User>(x => x.Login == u.Login && x.Email == u.Email).Any())
            {
                dal.Insert<User>(u);
                dal.Commit();
            }
            else if (!dal.GetWhere<User>(x => x.Login == u.Login).Any())
                throw new ServiceException("User with login " + u.Login + " already exists.");
            else throw new ServiceException("User with email " + u.Email + " already exists.");
        }

        public void AddPaper(Paper p)
        {
            // No debe haber otro artículo con el mismo título
            if (!dal.GetWhere<Paper>(x => x.Id == p.Id).Any())
            {
                dal.Insert<Paper>(p);
                dal.Commit();
            }
            else throw new ServiceException("Ya existe existe este artículo");
        }

        public void Login(string login, string password)
        {
            if (login.Length == 0) { throw new ServiceException("Introduce un login"); }
            if (password.Length == 0) { throw new ServiceException("Introduce una contraseña"); }

            User userAux = null;

            try
            {
                userAux = dal.GetWhere<User>(x => x.Login == login).First<User>();
            } 
            catch (Exception e)
            {
                throw new ServiceException("User with login " + login + " doesn't exist.");
            }                       
                if (userAux.Password == password)
                {
                    uLog = userAux;
                }
                else throw new ServiceException("Password is incorrect."); 
        }
        public User UserLogged()
        {
            return uLog;
        }

        public void Logout()
        {
            uLog = null;
        }
        public Area FindAreaByName(string nombreArea)
        {
            Area area = dal.GetWhere<Area>(x => x.Name == nombreArea).First<Area>();
            if (area != null) { return area; }
            else throw new ServiceException("El área no existe");
        }

        public Person FindPersonById(string id)
        {
            Person person = dal.GetWhere<Person>(x => x.Id == id).First<Person>();
            if (person != null) { return person; }
            else return null;
        }

        public Person FindPersonByName(string name, string surname)
        {
            
            IEnumerable<Person> person = dal.GetWhere<Person>(x => x.Name == name && x.Surname == surname);
            if (person.Count<Person>() != 0) { return person.First<Person>(); }
            else return null;
        }

        public Magazine.Entities.Magazine GetMagazine()
        {
            Magazine.Entities.Magazine revista = dal.GetAll<Magazine.Entities.Magazine>().First<Magazine.Entities.Magazine>();
            return revista;
        }

        public void AddIssue(Issue i)
        {
            // Si el Issue ya existe, al modificarlo hay que borrarlo y volver a insertar el nuevo
            Issue aux = dal.GetWhere<Issue>(x => x.Id == i.Id).First<Issue>();
            if (aux != null)
            {
                dal.Delete<Issue>(aux);
                dal.Insert<Issue>(i);
                dal.Commit();
            }
            else dal.Insert<Issue>(i);
        }

        public ICollection<Area> GetAllAreas()
        {
            return dal.GetAll<Area>().ToList();
        }

        public ICollection<Paper> ShowData(ICollection<Area> areas)
        {
            ICollection<Paper> res = new List<Paper>();
            for(int i = 0; i < areas.Count; i++)
            {
                ICollection<Paper> aux = areas.ElementAt(i).GetPapers();
                for (int j = 0; j < aux.Count; j++)
                {
                    res.Add(aux.ElementAt(i));
                } 
            }

            return res;
        }
        public ICollection<Paper> ReturnEvaluationPending(string nombreArea)
        {
            Area a = FindAreaByName(nombreArea);
            return a.EvaluationPending;
            //if (a != null) { return a.EvaluationPending; } ??
            //else return null;
        }

        public void setEvPaper(Area a, Paper paper, string comentarios, Boolean acepted)
        {
            
            Paper p = dal.GetWhere<Paper>(x => x.Id == paper.Id).First<Paper>();
            p.Evaluation = new Evaluation(acepted, comentarios, DateTime.Today);

            if (p.Evaluation.Accepted)
            {
               a.PublicationPending.Add(p);
            }

            a.EvaluationPending.Remove(p);
        }

        public Paper FindPaperByTitle(String titulo) 
        {
            Paper p = dal.GetWhere<Paper>(x => x.Title == titulo).First<Paper>();
            if (p != null) { return p; }
            else return null;
        }

    }


}
