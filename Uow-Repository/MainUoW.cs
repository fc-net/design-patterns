using Uow_Repository.Repositories.Entities;
using Uow_Repository.UoW;

namespace Uow_Repository
{
    public class MainUoW
    {
        public static void Run()
        {
            IDataFactory dataFactory = new DataFactory();
            dataFactory.GetContext();

            IEmployeeRepository emp = new EmployeeRepository(dataFactory);
            IDepartamentRepository dpt = new DepartamentRepository(dataFactory);
            IUserRepository usr = new UserRepository(dataFactory);
            ITemplateRepository tmp = new TemplateRepository(dataFactory);

            IUnitOfWork uow = new UnitOfWork(dataFactory);

            Departaments departament = new Departaments()
            {
                Name = "Informatica Prueba"
            };

            Employees employee = new Employees()
            {
                Name = "Empleado1",
                Departaments = departament
            };

            dpt.Add(departament);
            emp.Add(employee);

            Templates template = new Templates()
            {
                Name = "TemplateTest2"
            };

            template.Users.Add(new Users()
            {
                Name = "UserTest2"
            });

            template.Users.Add(new Users()
            {
                Name = "Paco"
            });

            tmp.Add(template);

            uow.Commit();
        }
    }
}
