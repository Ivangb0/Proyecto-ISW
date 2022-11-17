﻿using Magazine.Entities;
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
            if (!dal.GetWhere<User>(x => x.Login == u.Login).Any() && !dal.GetWhere<User>(x => x.Email == u.Email).Any())
            {
                dal.Insert<User>(u);
                dal.Commit();
            }
            else if (!dal.GetWhere<User>(x => x.Login == u.Login).Any())
                throw new ServiceException("User with login " + u.Login + " already exists.");
            else throw new ServiceException("User with email " + u.Email + " already exists.");
        }

        public void Login(string login, string password)
        {
            if (dal.GetWhere<User>(x => x.Login == login).Any())
            {
                if (dal.GetWhere<User>(x => x.Login == login && x.Password == password).Any())
                {
                    //var context = new MagazineDbContext();
                    //uLog = context.Users.Single<User>(x => x.Login == login);
                    uLog = dal.GetWhere<User>(x => x.Login == login).First<User>();
                }
                else throw new ServiceException("Password is incorrect.");
            }
            else throw new ServiceException("User with login " + login + " doesn't exist.");
        }
        public User UserLogged()
        {
            return uLog;
        }

        public void Logout()
        {
            uLog = null;
        }

    }
}