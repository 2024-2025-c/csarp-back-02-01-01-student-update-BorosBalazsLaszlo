using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Enums;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2011,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2012,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                }
            };

            // Students
            modelBuilder.Entity<Student>().HasData(students);

            List<Teacher> techers = new List<Teacher>
            {
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Feleltető",
                    LastName="Ferenc",
                    BirthsDay=new DateTime(2001,8,1),
                    IsWoomen=false,
                    IsHeadTeacher=false
                },
                new Teacher
                {
                    Id=Guid.NewGuid(),
                    FirstName="Aranyos",
                    LastName="Aranka",
                    BirthsDay=new DateTime(2002,2,24),
                    IsWoomen=true,
                    IsHeadTeacher=true
                }
            };

            modelBuilder.Entity<Teacher>().HasData(techers);

            List<Parent> parent = new List<Parent>
            {
                new Parent
                {
                     Id = Guid.NewGuid(),
                    sz_FirstName = "Kovacs",
                    sz_LastName = "Moni",
                    sz_Bday = new DateTime(1968,02,12),
                    sz_Cim = "Bekescsaba, Bercsenyi u. 13",
                    sz_Nem = "Nő"
                },
                 new Parent
                {
                    Id = Guid.NewGuid(),
                    sz_FirstName = "Kovacs",
                    sz_LastName = "Laszlo",
                    sz_Bday = new DateTime(1969,03,22),
                    sz_Cim = "Bekescsaba, Bercsenyi u. 13",
                    sz_Nem = "Férfi"
                },
            };

            modelBuilder.Entity<Parent>().HasData(parent);

            List<Admin> admin = new List<Admin>
            {
              new Admin()
            {
                Id = Guid.NewGuid(),
                A_Firstname = "Kovacs",
                A_Lastname = "Jozsef",
                A_Bday = new DateTime(1995,02,11),
                Rendszergazda = false
            },
            new Admin()
            {
                Id = Guid.NewGuid(),
                A_Firstname = "Boros",
                A_Lastname = "Jozsef",
                A_Bday = new DateTime(1968,02,11),
                Rendszergazda = true
            },
            };

            modelBuilder.Entity<Admin>().HasData(admin);

            List<Dolgozo> dolgozo = new List<Dolgozo>
            {
              new Dolgozo()
            {
                Id = Guid.NewGuid(),
                D_Firstname = "Kovacs",
                D_Lastname = "Sandor",
                D_Bday = new DateTime(1995,02,11),
                Osztalyvezeto = false
            },
            new Dolgozo()
            {
               Id = Guid.NewGuid(),
                D_Firstname = "Kovacs",
                D_Lastname = "Gergo",
                D_Bday = new DateTime(1995,02,11),
                Osztalyvezeto = false
            },
            };

            modelBuilder.Entity<Dolgozo>().HasData(dolgozo);

            List<Rendeles> rendeles = new List<Rendeles>
            {
              new Rendeles()
            {
                Id = Guid.NewGuid(),
                Cegnev = "Amazon",
                Torekeny = false,
                R_Datum = new DateTime(2024,03,22),
                Description = "Processzorok",
            },
            new Rendeles()
            {
                Id = Guid.NewGuid(),
                Cegnev = "Microsoft",
                Torekeny = false,
                R_Datum = new DateTime(2024,03,22),
                Description = "Szamitogepek"
            },
            };

            modelBuilder.Entity<Rendeles>().HasData(rendeles);
        }
    }
}
