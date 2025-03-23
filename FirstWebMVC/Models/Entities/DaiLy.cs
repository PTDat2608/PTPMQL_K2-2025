using FirstWebMVC.Models.Entities;

namespace FirstWebMVC.Models.Entities
{
public class DaiLy : HeThongPhanPhoi

    {
    public required string MaDaiLy { get; set; }
    public string TenDaiLy { get; set; }
    public string DiaChi { get; set; }
    public string NguoiDaiDien { get; set; }

    public string DienThoai { get; set; }
    public string MaHTTP { get; set; }
    }     
}
