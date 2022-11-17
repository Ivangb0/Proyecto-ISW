using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.Validation;
using System.IO.Ports;

using Magazine.Entities;
using Magazine.Persistence;
using Magazine.Services;


namespace BusinessLogicTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Crea el objeto de servicio
                IMagazineService service = new MagazineService(new EntityFrameworkDAL(new MagazineDbContext()));

                // Lo pasa a Program para que lo utilice
                new Program(service);
            }
            catch (Exception e)
            {
                printError(e);
                Console.WriteLine("Press any key.");
                Console.ReadLine();
            }


        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }


        private IMagazineService service;

        Program(IMagazineService service)
        {
            this.service = service;

            DBInitialization();

            LoginTest();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // A partir de aquí vuestras pruebas

        }

        void DBInitialization()
        {
            try
            {
                Console.WriteLine("INITIALIZATING DB...");

                service.DBInitialization();
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("DATA CREATED.");
        }

        void LoginTest()
        {
            Console.WriteLine();
            Console.WriteLine("Testing login...");

            try
            {
                service.Login("theboss", "1234");
                if (service.UserLogged().Login != "theboss")
                    Console.Out.WriteLine("Error con el usuario identificado.");
                else
                    Console.Out.WriteLine("WELCOME " + service.UserLogged().Name + " " + service.UserLogged().Surname);
                service.Logout();
                if (service.UserLogged() != null)
                    Console.Out.WriteLine("Sigue alguien identificado.");
            }
            catch (Exception e)
            {
                printError(e);
            }

        }

        // A partir de aquí vuestras pruebas


    }


}
