using System;

class Araba
{
    public DateTime UretimTarihi { get; private set; }
    public string? SeriNumarasi { get; set; }
    public string? Marka { get; set; }
    public string? Model { get; set; }
    public string? Renk { get; set; }
    public int KapiSayisi { get; set; }

    public Araba()
    {
        UretimTarihi = DateTime.Now;
    }
}