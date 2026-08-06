namespace SuperApp.Views;

public partial class LoginPage : ContentPage
{
    private bool _isPasswordVisible = false;
    public LoginPage()
	{
		InitializeComponent();
	}
    // Toggle show/hide password
    private void TogglePasswordButton_Clicked(object sender, EventArgs e)
    {
        _isPasswordVisible = !_isPasswordVisible;
        PasswordEntry.IsPassword = !_isPasswordVisible;

        // Ganti icon sesuai state (siapkan 2 file: eye_icon.png & eye_off_icon.png di folder Resources/Images)
        TogglePasswordButton.Source = _isPasswordVisible ? "eye_off_icon.png" : "eye_icon.png";
    }

    // Event tombol MASUK
    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text?.Trim() ?? string.Empty;
        string password = PasswordEntry.Text ?? string.Empty;
        bool rememberMe = RememberMeSwitch.IsOn ?? false;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            await DisplayAlert("Validasi", "Email dan password wajib diisi.", "OK");
            return;
        }

        // TODO: Ganti dengan logic autentikasi Anda (API call, dsb)
        // Contoh: var result = await authService.LoginAsync(email, password, rememberMe);

        await Navigation.PushAsync(new HomePage());
    }

    // Event link "Lupa Password?"
    private async void ForgotPassword_Tapped(object sender, EventArgs e)
    {
        // TODO: Navigasi ke halaman ForgotPasswordPage
        await DisplayAlert("Lupa Password", "Arahkan ke halaman reset password di sini.", "OK");
        // await Navigation.PushAsync(new ForgotPasswordPage());
    }

    // Event link "Daftar di sini"
    private async void Register_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
}