using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine.Entities;


namespace Magazine.Services
{
    public interface IMagazineService
    {
        void RemoveAllData();
        void Commit();

        // Necesario para la inicialización de la BD
        void DBInitialization();
        void AddPerson(Person p);
        void AddMagazine(Magazine.Entities.Magazine m);
        void AddArea(Area a);

        // A partir de aquí cread los vuestros
        void AddUser(User u);

        void AddPaper(Paper p);

        void AddIssue(Issue i);

        void Login(string login, string password);

        User UserLogged();

        void Logout();

        Area FindAreaByName(string nombreArea);

        Person FindPersonById(string id);

        Magazine.Entities.Magazine GetMagazine(); 
    }
}
