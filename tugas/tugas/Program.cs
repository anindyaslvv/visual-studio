// See https://aka.ms/new-console-template for more information
int jamkerja = 10;
int hargaperjam = 15000;
int gajidibayar;
int l;

//cek kondisi jika lebih dari 7 jam 
if (jamkerja > 7)
{
    //proses gaji dibayar 
    l = jamkerja - 7;
    if (l == 1)
    {
        gajidibayar = (hargaperjam * jamkerja) + 10000;
    }
    else
    {
        gajidibayar = (hargaperjam * jamkerja);
    }
    //proses gaji dibayar 
    l = jamkerja - 7;
    if (l == 2)
    {
        gajidibayar = (hargaperjam * jamkerja) + 20000;
    }
    else
    {
        gajidibayar = (hargaperjam * jamkerja);
    }
    //proses gaji dibayar
    l = jamkerja - 7;
    if (l == 3)
    {
        gajidibayar = (hargaperjam * jamkerja) + 30000;
    }
    else
    {
        gajidibayar = (hargaperjam * jamkerja);
    }
    //proses gaji dibayar 
    l = jamkerja - 7;
    if (l == 4)
    {
        gajidibayar = (hargaperjam * jamkerja) + 100000;
    }
    else
    {
        gajidibayar = (hargaperjam * jamkerja);
    }
    //jika normal 

    Console.WriteLine("tampilkan gaji dibayar : " + gajidibayar);
    Console.ReadKey();
}







