namespace dio_curso_introducao_ao_c_sharp.Exemplos
{
    public class Calculadora
    {
        private float numeroUm;
        private float numeroDois;

        public float Soma(float numeroUm, float numeroDois)
        {
            this.numeroUm = numeroUm;
            this.numeroDois = numeroDois;
            return this.numeroUm + this.numeroDois;
        }

        public float Subtracao(float numeroUm, float numeroDois)
        {
            this.numeroUm = numeroUm;
            this.numeroDois = numeroDois;
            return this.numeroUm - this.numeroDois;
        }

        public float Multiplicacao(float numeroUm, float numeroDois)
        {
            this.numeroUm = numeroUm;
            this.numeroDois = numeroDois;
            return this.numeroUm * this.numeroDois;
        }

        public float Divisao(float numeroUm, float numeroDois)
        {
            this.numeroUm = numeroUm;
            this.numeroDois = numeroDois;
            return this.numeroUm / this.numeroDois;
        }
    }
}
