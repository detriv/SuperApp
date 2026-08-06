using System;
using System.Collections.Generic;
using System.Text;

namespace SuperApp.Models;

public class MenuItem
{
    public string Title { get; set; } = string.Empty;
    // Kode unicode glyph dari font MaterialIcons-Regular.ttf, contoh: "\ue871"
    public string IconGlyph { get; set; } = string.Empty;
    public Color IconColor { get; set; } = Color.FromArgb("#5B67F1");
    public Color BackgroundColor { get; set; } = Color.FromArgb("#EEEDFE");
    // Nama route/halaman tujuan saat menu ini di-tap (opsional, isi sesuai kebutuhan navigasi Anda)
    public string Route { get; set; } = string.Empty;
}