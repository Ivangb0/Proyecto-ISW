using System;
using System.Data.Entity.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Magazine.Entities;
using Magazine.Persistence;


namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                new Program();
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("\nPulse una tecla para salir");
            Console.ReadLine();
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


        Program()
        {
            IDAL dal = new EntityFrameworkDAL(new MagazineDbContext());

            CreateSampleDB(dal);
            PrintSampleDB(dal);
        }

        private void CreateSampleDB(IDAL dal)
        {
            dal.RemoveAllData();
            Console.WriteLine("Creando los datos y almacenándolos en la BD");
            Console.WriteLine("===========================================");

            Console.WriteLine("\n// CREACIÓN DE UNA REVISTA Y SU EDITOR EN JEFE");
            User u1 = new User("1234", "Pepe", "TheBoss", false, "ninguna", "pgarcia@gmail.com", "theboss", "1234");
            dal.Insert<User>(u1);
            dal.Commit();

            Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista Universitaria", u1);
            u1.Magazine = m;

            dal.Insert<Magazine.Entities.Magazine>(m);
            dal.Commit();
            
            User uEditor = new User("2002", "Juan", "Editor", false, "ninguna", "juan@gmail.com", "Editor", "2002");
            dal.Insert<User>(uEditor);
            dal.Commit();


            User uResponsable = new User("0987", "Javier", "Responsible", false, "ninguna", "javier@gmail.com", "Responsible", "0987");
            dal.Insert<User>(uResponsable);
            dal.Commit();

            Area a = new Area("Area", uEditor, m);
            dal.Insert<Area>(a);
            dal.Commit();

            Paper articulo = new Paper("Articulo1", new DateTime(2022, 10, 27), a, uResponsable);
            dal.Insert<Paper>(articulo);
            dal.Commit();

            a.EvaluationPending.Add(articulo);
            //a.Papers.Add(articulo);
            //a.PublicationPending.Add(articulo);

            Paper articulo1 = new Paper("Articulo2", new DateTime(2022, 10, 27), a, uResponsable);
            dal.Insert<Paper>(articulo1);
            dal.Commit();

            Paper articulo2 = new Paper("Articulo3", new DateTime(2022, 10, 27), a, uResponsable);
            dal.Insert<Paper>(articulo2);
            dal.Commit();

            Issue i1 = new Issue(1, m);
            dal.Insert<Issue>(i1);
            dal.Commit();

            Issue i2 = new Issue(2, m);
            dal.Insert<Issue>(i2);
            dal.Commit();

            i2.AddPaper(articulo1);
            i2.AddPaper(articulo2);

            Console.WriteLine("Nombre de la revista: " + m.Name);
            Console.WriteLine("  Editor de la revista: " + m.ChiefEditor.Name + " " + m.ChiefEditor.Surname);

            Console.ReadKey();

            // Populate here the rest of the database with data

        }
        // AÑADIR A DBTEST 

        // Copiar a partir de aquí
        private void PrintSampleDB(IDAL dal)
        {
            Console.WriteLine("\n\nMOSTRANDO LOS DATOS DE LA BD");
            Console.WriteLine("============================\n");
            Magazine.Entities.Magazine m = dal.GetWhere<Magazine.Entities.Magazine>(x => x.Name == "Revista Universitaria").First();

            Console.WriteLine("Nombre de la revista: " + m.Name);
            Console.WriteLine("  Editor de la revista: " + m.ChiefEditor.Name + " " + m.ChiefEditor.Surname);

            foreach (Area a in m.Areas)
            {
                Console.WriteLine("    Area: " + a.Name + " Editor: " + a.Editor.Name + " " + a.Editor.Surname);
                Console.WriteLine("      Enviados:");
                foreach (Paper p in a.Papers)
                {
                    Console.WriteLine("        Artículo: " + p.Title + ",  " + p.Responsible.Name + " " + p.Responsible.Surname);
                    foreach (Person pe in p.CoAuthors)
                        Console.WriteLine("           CoAuthor: " + pe.Name + " " + pe.Surname);
                }
                Console.WriteLine("      Pendientes de evaluación:");
                foreach (Paper p in a.EvaluationPending)
                    Console.WriteLine("        Artículo: " + p.Title);
                Console.WriteLine("      Pendientes de publicación:");
                foreach (Paper p in a.PublicationPending)
                    Console.WriteLine("        Artículo: " + p.Title);
            }

            Console.WriteLine();
            foreach (Issue i in m.Issues)
            {
                Console.WriteLine("    Ejemplar número: " + i.Number);
                foreach (Paper p in i.PublishedPapers)
                    Console.WriteLine("        Artículo: " + p.Title + ",  " + p.Responsible.Name + " " + p.Responsible.Surname);
            }
        }
        // Hasta aquí
    }

}
