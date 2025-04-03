// exercício 1
//class program
//{
//    class alunos
//    {
//        private string nome;
//        private int matricula;
//        private float p1, p2, TP, mediaI;

//        public alunos(string nome, int matricula, float p1, float p2, float TP)
//        {
//            this.nome = nome;
//            this.matricula = matricula;
//            this.p1 = p1;
//            this.p2 = p2;
//            this.TP = TP;
//        }
//        public void media ()
//        {
//            float media;
//            media = (float)(p1 * 2.5 + p2 * 2.5 + TP * 2) / 7;
//            mediaI = media;
//        }

//        public float final ()
//        {
//            float falta;
//            if (mediaI >= 7)
//            {
//                return 0;
//            }
//            else
//            {
//                falta = 7 - mediaI;
//                return (falta);
//            }
//        }
//    }

//    static void Main(string[] args)
//    {
//        string nome;
//        int matricula;
//        float p1, p2, TP;
//        Console.Write("entre com seu nome: ");
//        nome = Console.ReadLine();

//        Console.Write("entre com seu número de matrícula: ");
//        matricula = int.Parse(Console.ReadLine());

//        Console.Write("entre com o valor da sua primeira prova: ");
//        p1 = int.Parse(Console.ReadLine());
//        Console.Write("entre com o valor da sua segunda prova: ");
//        p2 = int.Parse(Console.ReadLine());
//        Console.Write("entre com seu valor de trabalho: ");
//        TP = int.Parse(Console.ReadLine());

//        alunos alunos = new alunos(nome, matricula, p1, p2, TP);
//        alunos.media ();

//        float falta = alunos.final();
//        Console.WriteLine("você precisa de {0} pontos na prova final.", falta);
//    }
//}

//exercício 2

class program
{
    static void Main(string[] args)
    {
        data data = new data();
        int dia, mes, ano;
        do
        {
            Console.Write("entre com o ano: ");
            ano = int.Parse(Console.ReadLine());

            Console.Write("entre com o mês: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("entre com o dia: ");
            dia = int.Parse(Console.ReadLine());



            data.getano(ano);
            data.getmes(mes);
            data.getdia(dia);
        } while (data.construtor() == "01/01/0001");

        data.clone();

            Console.WriteLine("{0}/{1}/{2}", dia, mes, ano);

    }
    class data
    {
        private int dia, mes, ano;
        private string mesextenso;

        public string construtor ()
        {
            
            if (ano >= 0)
            {
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia <= 31 && dia >= 1) 
                    {
                        return "correta";
                    }
                    else
                    {
                        return "01/01/0001";
                    }
                }
     
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia <= 30 && dia >= 1) 
                    {
                        return "correta";
                    }
                    else
                    {
                        return "01/01/0001";
                    }
                }

                else if (mes == 2)
                {
                    if (isbissexto(ano))
                    {
                        if (dia <= 29 && dia >= 1) 
                        {
                            return "correta";
                        }
                        else
                        {
                            return "01/01/0001";
                        }
                    }
                    else
                    {
                        if (dia <=28 && dia >= 1) 
                        {
                            return "correta";
                        }
                        else
                        {
                            return "01/01/0001";
                        }
                    }
                }
                else
                {
                    return "01/01/0001";
                }
            }
            else
            {
                return "01/01/0001";
            }
        }

        public int getano (int ano)
        {
            this.ano = ano;
            return ano;
        }

        public int getmes(int mes)
        {
            this.mes = mes;
            return mes;
        }

        public int getdia(int dia)
        {
            this.dia = dia;
            return dia;
        }

        public bool isbissexto(float ano)
        {
            float div4, div100, div400;

            div4 = ano / 4;
            div100 = ano / 100;
            div400 = ano / 400;

            if (div4 != (int)div4)
            {
                return false;
            }
            else if (div100 != (int)div100)
            {
                return true;
            }
            else if (div400 != (int)div400)
                {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string getmesextenso(int mes)
        {
            if (mes == 2)
            {
                mesextenso = "fevereiro";
                return mesextenso;
            }
            else if (mes == 3)
            {
                mesextenso = "março";
                return mesextenso;
            }
            else if (mes == 4)
            {
                mesextenso = "abril";
                return mesextenso;
            }
            else if (mes == 5)
            {
                mesextenso = "maio";
                return mesextenso;
            }
            else if (mes == 6)
            {
                mesextenso = "junho";
                return mesextenso;
            }
            else if (mes == 7)
            {
                mesextenso = "julho";
                return mesextenso;
            }
            else if (mes == 8)
            {
                mesextenso = "agosto";
                return mesextenso;
            }
            else if (mes == 9)
            {
                mesextenso = "setembro";
                return mesextenso;
            }
            else if (mes == 10)
            {
                mesextenso = "outubro";
                return mesextenso;
            }
            else if (mes == 11)
            {
                mesextenso = "novembro";
                return mesextenso;
            }
            else if (mes == 12)
            {
                mesextenso = "dezembro";
                return mesextenso;
            }
            else
            {
                mesextenso = "janeiro";
                return mesextenso;
            }
        }

        public void clone ()
        {
            int dia, mes, ano; string mesextenso;
            dia = this.dia;
            mes = this.mes;
            ano = this.ano;
            mesextenso=this.mesextenso;
        }
    }
}