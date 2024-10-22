using System;
using System.Collections.Generic;

namespace tem3.Models;

public partial class TLoaiSach
{
    public string MaLoai { get; set; } = null!;

    public string? TenLoai { get; set; }

    public virtual ICollection<TSach> TSaches { get; set; } = new List<TSach>();
}
