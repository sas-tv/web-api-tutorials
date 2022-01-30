using EmployeeManagementSystem.ApplicationServices.Interfaces;
using EmployeeManagementSystem.Repositories.Interfaces;

namespace EmployeeManagementSystem.ApplicationServices
{
    public class TestWService : ITestWService
    {
        #region Private Variables
        private ITestWRepository _TestWRepo;
        #endregion

        #region Constructors
        public TestWService(ITestWRepository testWRepo)
        {
            _TestWRepo = testWRepo;
        }
        #endregion

        #region Public Methods

        public string GetName()
        {
            return _TestWRepo.GetName();
        }
        #endregion
    }
}
