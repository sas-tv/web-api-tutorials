using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestMService : ITestMService
    {
        #region Private Variables
        private ITestMRepository _TestMRepo;
        #endregion

        #region Constructors
        public TestMService(ITestMRepository testMRepo)
        {
            _TestMRepo = testMRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestMRepo.GetName();
        }
        #endregion
    }
}
