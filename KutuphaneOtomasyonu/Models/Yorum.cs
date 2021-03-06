﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Models
{
    public class Yorum
    {
        public int Id { get; set; }
        [Required]
        public string Icerik { get; set; }
        public DateTime olusturulmaTarihi { get; set; }
        public int KitapId { get; set; }
        public Kitap Kitap { get; set; }  /// FK
        public string UserId { get; set; }
        public KisiselBilgiler User { get; set; }

    }
}
