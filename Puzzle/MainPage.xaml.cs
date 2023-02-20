namespace Puzzle;

public partial class MainPage : ContentPage
{
	Button[,] botones = new Button[4, 4];
    
	public MainPage()
	{
		InitializeComponent();
        asigna();
        numeros_aleatorios();
       
	}
    int filas = 0, columnas = 0;

    void numeros_aleatorios()
	{
        Random rand = new Random();
        List<int> numeros = new List<int>();

        while (numeros.Count < 15)
        {
            int num = rand.Next(1, 16);
            if (!numeros.Contains(num))
            {
                numeros.Add(num);
            }
        }


        for(int i = 0; i < numeros.Count; i++) { 
            botones[filas, columnas].Text = numeros[i].ToString();
            columnas+=1;
            if(columnas == 4)
            {
                filas += 1;
                columnas = 0;
            }
           
        }
        

        botones[3, 3].Text = botones[0, 1].Text;
        botones[0, 1].Text = " ";

        botones[0, 1].BackgroundColor = Colors.Black;

    }

    

    void asigna()
	{
		botones[0, 0] = btndorn_00;
        botones[0, 1] = btndorn_01;
        botones[0, 2] = btndorn_02;
        botones[0, 3] = btndorn_03;
        botones[1, 0] = btndorn_10;
        botones[1, 1] = btndorn_11;
        botones[1, 2] = btndorn_12;
        botones[1, 3] = btndorn_13;
        botones[2, 0] = btndorn_20;
        botones[2, 1] = btndorn_21;
        botones[2, 2] = btndorn_22;
        botones[2, 3] = btndorn_23;
        botones[3, 0] = btndorn_30;
        botones[3, 1] = btndorn_31;
        botones[3, 2] = btndorn_32;
        botones[3, 3] = btndorn_33;

    }
    void arriba(Button b)
    {

        Console.WriteLine("Entra arriba");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (b.Text == botones[i, j].Text && (i != 0))
                {
                    int n = i - 1;
                    if (botones[n, j].Text == " ")
                    {

                        Console.WriteLine("Bandera arriba");
                        botones[n, j].Text = botones[i, j].Text;
                        botones[n, j].BackgroundColor = Colors.White;
                        botones[n, j].TextColor = Colors.Blue;
                        botones[i, j].Text = " ";
                        botones[i, j].BackgroundColor = Colors.Black;

                    }
                }
            }
        }
    }



    void derecha(Button b)
    {

        Console.WriteLine("Entra en derecha");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (b.Text == botones[i, j].Text && (j!= 3))
                {
                    int n = j + 1;
                    if (botones[i, n].Text == " ")
                    {

                        Console.WriteLine("Bandera derecha");
                        botones[i, n].Text = botones[i, j].Text;
                        botones[i, n].BackgroundColor = Colors.White;
                        botones[i, n].TextColor = Colors.Blue;
                        botones[i, j].Text = " ";
                        botones[i, j].BackgroundColor = Colors.Black;
                        
                    }
                }
            }
        }
    }

    void izquierda(Button b)
    {

        Console.WriteLine("Entra en izquierda");

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (b.Text == botones[i, j].Text)
                {
                    Console.WriteLine("entro aqui");
                    int n = j - 1;
                    if (botones[i, n].Text == " ")
                    {
                        Console.WriteLine("Bandera iquierda");
                        botones[i, n].Text = botones[i, j].Text;
                        botones[i, n].BackgroundColor = Colors.White;
                        botones[i, n].TextColor = Colors.Blue;
                        botones[i, j].Text = " ";
                        botones[i, j].BackgroundColor = Colors.Black;
                        
                    }
                }
            }
        }
    }


    void btndorn_00_Clicked(System.Object sender, System.EventArgs e)
    {

        Button b = sender as Button;

        
            derecha(b);
        
            izquierda(b);

            arriba(b);
        
        

    }

}


