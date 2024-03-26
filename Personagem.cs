namespace KaueJean;
 public class Personagem
 {
    protected double fome;
    protected double sede;
    protected double sono;

 public Personagem()
 {
    fome = 0;
    sede = 0;
    sono = 0;
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