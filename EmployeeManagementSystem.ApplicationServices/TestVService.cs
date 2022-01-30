using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestVService : ITestVService
    {
        #region Private Variables
        private ITestVRepository _TestVRepo;
        #endregion

        #region Constructors
        public TestVService(ITestVRepository testVRepo)
        {
            _TestVRepo = testVRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestVRepo.GetName();
        }
        #endregion
    }
}
