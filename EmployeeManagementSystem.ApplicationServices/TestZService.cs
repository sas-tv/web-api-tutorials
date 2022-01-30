using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestZService : ITestZService
    {
        #region Private Variables
        private ITestZRepository _TestZRepo;
        #endregion

        #region Constructors
        public TestZService(ITestZRepository testZRepo)
        {
            _TestZRepo = testZRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestZRepo.GetName();
        }
        #endregion
    }
}
