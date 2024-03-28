namespace KaueJean;
 public class Personagem
 {
    public double fome;
    public double sede;
    public double sono;
    public string NomeDaFoto;

 public Personagem()
 {
    fome = 0;
    sede = 0;
    sono = 0;
    NomeDaFoto = "";
 }   
 public string GetNomeDaFoto()
    {
        return NomeDaFoto; 
    }
 public void SetFome (double f)
 {
    if (f >= 0 && f <= 1)
    fome = f 
    else if (f > 1)
    fome = 1; 
    else if (f < 0)
    fome = 0;
 }
 }