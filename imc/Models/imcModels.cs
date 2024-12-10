namespace imc.Models
{
    public class imcModels
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public double IMC
        {
            get
            {

                return Peso/(Altura*Altura);
               
            }


        }

       public string CategoriaIMC
        {
            get
            {
                double imc = IMC;
                if (imc > 18.5)
                {
                    return "Bajo de peso";
                }
                else if (imc >= 18.5 && imc < 24.9)
                {
                    return "Peso normal";
                }
                else if (imc >= 25 && imc < 29.9)
                {
                    return "Peso alto";
                }
                else
                {
                    return "Bajo de peso";
                }
            }

        }
}
}
