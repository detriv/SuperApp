using System;
using System.Collections.Generic;
using System.Text;

namespace SuperApp.Models;

public class BannerItem
{
    public string Title { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public Color BackgroundColor { get; set; } = Color.FromArgb("#5B67F1");
}
