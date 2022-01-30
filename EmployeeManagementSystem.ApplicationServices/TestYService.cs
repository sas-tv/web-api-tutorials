using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestYService : ITestYService
    {
        #region Private Variables
        private ITestYRepository _TestYRepo;
        #endregion

        #region Constructors
        public TestYService(ITestYRepository testYRepo)
        {
            _TestYRepo = testYRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestYRepo.GetName();
        }
        #endregion
    }
}
