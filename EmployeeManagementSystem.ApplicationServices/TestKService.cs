using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestKService : ITestKService
    {
        #region Private Variables
        private ITestKRepository _TestKRepo;
        #endregion

        #region Constructors
        public TestKService(ITestKRepository testKRepo)
        {
            _TestKRepo = testKRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestKRepo.GetName();
        }
        #endregion
    }
}
