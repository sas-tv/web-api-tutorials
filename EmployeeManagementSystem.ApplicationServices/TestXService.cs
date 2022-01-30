using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestXService : ITestXService
    {
        #region Private Variables
        private ITestXRepository _TestXRepo;
        #endregion

        #region Constructors
        public TestXService(ITestXRepository testXRepo)
        {
            _TestXRepo = testXRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestXRepo.GetName();
        }
        #endregion
    }
}
