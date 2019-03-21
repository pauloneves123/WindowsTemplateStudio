//{[{
using Param_RootNamespace.Core.Services;
using Param_RootNamespace.Core.Helpers;
//}]}

namespace Param_RootNamespace.ViewModels
{
    public class ShellViewModel : Observable
    {
        private ICommand _menuFileExitCommand;
//{[{
        private ICommand _userProfileCommand;

        private IdentityService IdentityService => Singleton<IdentityService>.Instance;
//}]}
        public ICommand MenuFileExitCommand => _menuFileExitCommand ?? (_menuFileExitCommand = new RelayCommand(OnMenuFileExit));
//^^
//{[{
        public ICommand UserProfileCommand => _userProfileCommand ?? (_userProfileCommand = new RelayCommand(OnUserProfile));
//}]}

        public ShellViewModel()
        {
        }

//^^
//{[{
        private void OnUserProfile()
        {
            MenuNavigationHelper.OpenInRightPane(typeof(SettingsPage));
        }
//}]}
    }
}
