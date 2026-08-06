namespace SuperApp.Views;

public partial class RegisterPage : ContentPage
{
    private bool _isPasswordVisible = false;
    private bool _isConfirmPasswordVisible = false;

    public RegisterPage()
    {
        InitializeComponent();
    }

    // Toggle show/hide password
    private void TogglePasswordButton_Clicked(object sender, EventArgs e)
    {
        _isPasswordVisible = !_isPasswordVisible;
        PasswordEntry.IsPassword = !_isPasswordVisible;
        TogglePasswordButton.Source = _isPasswordVisible ? "eye_off_icon.png" : "eye_icon.png";
    }

    // Toggle show/hide confirm password
    private void ToggleConfirmPasswordButton_Clicked(object sender, EventArgs e)
    {
        _isConfirmPasswordVisible = !_isConfirmPasswordVisible;
        ConfirmPasswordEntry.IsPassword = !_isConfirmPasswordVisible;
        ToggleConfirmPasswordButton.Source = _isConfirmPasswordVisible ? "eye_off_icon.png" : "eye_icon.png";
    }

    // Event tombol DAFTAR
    private async void SubmitButton_Clicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text?.Trim() ?? string.Empty;
        string password = PasswordEntry.Text ?? string.Empty;
        string confirmPassword = ConfirmPasswordEntry.Text ?? string.Empty;

        // ===== Validasi =====
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
        {
            ShowError("Semua kolom wajib diisi.");
            return;
        }

        if (!IsValidEmail(email))
        {
            ShowError("Format email tidak valid.");
            return;
        }

        if (password.Length < 6)
        {
            ShowError("Password minimal 6 karakter.");
            return;
        }

        if (password != confirmPassword)
        {
            ShowError("Konfirmasi password tidak cocok.");
            return;
        }

        HideError();

        // TODO: Ganti dengan logic registrasi asli Anda (API call, dsb)
        // Contoh: var result = await authService.RegisterAsync(email, password);

        await DisplayAlert("Berhasil", $"Akun berhasil dibuat untuk: {email}", "OK");

        // Setelah berhasil daftar, arahkan kembali ke halaman Login
        await Navigation.PopAsync();
    }

    // Event tombol / link "Sudah punya akun? Masuk"
    private async void BackToLogin_Tapped(object sender, EventArgs e)
    {
        // Jika RegisterPage dibuka lewat PushAsync dari LoginPage, cukup pop kembali
        if (Navigation.NavigationStack.Count > 1)
        {
            await Navigation.PopAsync();
        }
        else
        {
            // Jika RegisterPage adalah halaman awal (mis. root), buka LoginPage baru
            await Navigation.PushAsync(new LoginPage());
        }
    }

    private void ShowError(string message)
    {
        ErrorLabel.Text = message;
        ErrorLabel.IsVisible = true;
    }

    private void HideError()
    {
        ErrorLabel.IsVisible = false;
    }

    private static bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}