using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestFService : ITestFService
    {
        #region Private Variables
        private ITestFRepository _TestFRepo;
        #endregion

        #region Constructors
        public TestFService(ITestFRepository testFRepo)
        {
            _TestFRepo = testFRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestFRepo.GetName();
        }
        #endregion
    }
}
