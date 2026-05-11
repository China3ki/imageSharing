using imageSharing.Shared.Dto;
using Microsoft.AspNetCore.Components.Forms;

namespace imageSharing.Client.Pages
{
    public partial class Register
    {
        private RegisterDto _loginDto = new();
        private EditContext? _loginContext;
        public Register()
        {
            _loginContext = new(new RegisterDto());
        }
    }
}
