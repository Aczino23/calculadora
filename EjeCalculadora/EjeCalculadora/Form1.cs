namespace EjeCalculadora;

public partial class Form1 : Form
{
    // botones calculadora normal
    private Button btnBorrarUltimo;
    private Button btnBorrarActual;
    private Button btnBorrarTodo;
    private Button btnSigno;
    private Button btn7;
    private Button btn8;
    private Button btn9;
    private Button btnSuma;
    private Button btn4;
    private Button btn5;
    private Button btn6;
    private Button btnResta;
    private Button btn1;
    private Button btn2;
    private Button btn3;
    private Button btnMultiplicacion;
    private Button btn0;
    private Button btnPunto;
    private Button btnIgual;
    private Button btnDivision;
    // botones calculadora cientifica
    private Button btnPi;
    private Button btLog;
    private Button btnSqrt;
    private Button btnCuadrado;
    private Button btnSinh;
    private Button btnSin;
    private Button btnDecimal;
    private Button btnXy;
    private Button btnCosh;
    private Button btnCos;
    private Button btnBin;
    private Button btn1X;
    private Button btnTanh;
    private Button btnTan;
    private Button btnHex;
    private Button btnLnx;
    private Button btnExp; 
    private Button btnMod;
    private Button btnOct;
    private Button btnFac;
    
    // menu
    private MenuStrip menu;
    private ToolStripMenuItem catTipo;
    private ToolStripMenuItem miEstandar;
    private ToolStripMenuItem miCientifica;
    
    private TextBox txtDisplay;
    private Label lblOperacion;
    private String operacion;
    private Double resultado;
    
    public Form1()
    {
        operacion="";
        resultado=0;
        txtDisplay= new TextBox();
        lblOperacion= new Label();
        btnBorrarUltimo= new Button();
        btnBorrarActual= new Button();
        btnBorrarTodo= new Button();
        btnSigno= new Button();
        btn7= new Button();
        btn8= new Button();
        btn9= new Button();
        btnSuma= new Button();
        btn4= new Button();
        btn5= new Button();
        btn6= new Button();
        btnResta= new Button();
        btn1= new Button();
        btn2= new Button();
        btn3= new Button();
        btnMultiplicacion= new Button();
        btn0= new Button();
        btnPunto= new Button();
        btnIgual= new Button();
        btnDivision= new Button();
        lblOperacion= new Label();
        btnBorrarUltimo= new Button();
        btnBorrarActual= new Button();
        btnBorrarTodo= new Button();
        btnSigno= new Button();
        btn7= new Button();
        btn8= new Button();
        btn9= new Button();
        btnSuma= new Button();
        btn4= new Button();
        btn5= new Button();
        btn6= new Button();
        btnResta= new Button();
        btn1= new Button();
        btn2= new Button();
        btn3= new Button();
        btnMultiplicacion= new Button();
        btn0= new Button();
        btnPunto= new Button();
        btnIgual= new Button();
        btnDivision= new Button();
        // inicializar botones calculadora cientifica
        btnPi = new Button();
        btLog = new Button();
        btnSqrt = new Button();
        btnCuadrado = new Button();
        btnSinh = new Button();
        btnSin = new Button();
        btnDecimal = new Button();
        btnXy = new Button();
        btnCosh = new Button();
        btnCos = new Button();
        btnBin = new Button();
        btn1X = new Button();
        btnTanh = new Button();
        btnTan = new Button();
        btnHex = new Button();
        btnLnx = new Button();
        btnExp = new Button();
        btnMod = new Button();
        btnOct = new Button();
        btnFac = new Button();
        // inicializar menu
        menu = new MenuStrip();
        catTipo = new ToolStripMenuItem();
        miEstandar = new ToolStripMenuItem();
        miCientifica = new ToolStripMenuItem();
        
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        this.Size=new Size(600,500);
        this.Text="Calculadora";
        // no poder redimensionar la ventana
        this.FormBorderStyle=FormBorderStyle.FixedSingle;
        //Tamaño de botones
        btnBorrarUltimo.Size=new Size(60,60);
        btnBorrarActual.Size=new Size(60,60);
        btnBorrarTodo.Size=new Size(60,60);
        btnSigno.Size=new Size(60,60);
        btn7.Size=new Size(60,60);
        btn8.Size=new Size(60,60);
        btn9.Size=new Size(60,60);
        btnSuma.Size=new Size(60,60);
        btn4.Size=new Size(60,60);
        btn5.Size=new Size(60,60);
        btn6.Size=new Size(60,60);
        btnResta.Size=new Size(60,60);
        btn1.Size=new Size(60,60);
        btn2.Size=new Size(60,60);
        btn3.Size=new Size(60,60);
        btnMultiplicacion.Size=new Size(60,60);
        btn0.Size=new Size(60,60);
        btnPunto.Size=new Size(60,60);
        btnIgual.Size=new Size(60,60);
        btnDivision.Size=new Size(60,60);
        
        // tamaño de los botones calculadora cientifica
        btnPi.Size=new Size(60,60);
        btLog.Size=new Size(60,60);
        btnSqrt.Size=new Size(60,60);              
        btnCuadrado.Size=new Size(60,60);
        btnSinh.Size=new Size(60,60);
        btnSin.Size=new Size(60,60);
        btnDecimal.Size=new Size(60,60);
        btnXy.Size=new Size(60,60);
        btnCos.Size=new Size(60,60);
        btnCosh.Size=new Size(60,60);
        btnBin.Size=new Size(60,60);
        btn1X.Size=new Size(60,60);
        btnTanh.Size=new Size(60,60);
        btnTan.Size=new Size(60,60);
        btnHex.Size=new Size(60,60);
        btnLnx.Size=new Size(60,60);
        btnExp.Size=new Size(60,60);
        btnMod.Size=new Size(60,60);
        btnOct.Size=new Size(60,60);
        btnFac.Size=new Size(60,60);
        
        txtDisplay.Size=new Size(558,50);
        txtDisplay.Multiline=true;
        lblOperacion.AutoSize=true;
        txtDisplay.TextAlign=HorizontalAlignment.Right;
        // no poder escribir texto en el display
        txtDisplay.ReadOnly=true;
        
        //Texto
        btnBorrarUltimo.Text="⌫";                              
        btnBorrarActual.Text="CE";
        btnBorrarTodo.Text="C";
        btnSigno.Text="±";
        btn7.Text="7";
        btn8.Text="8";
        btn9.Text="9";
        btnSuma.Text="+";
        btn4.Text="4";
        btn5.Text="5";
        btn6.Text="6";
        btnResta.Text="-";
        btn1.Text="1";
        btn2.Text="2";
        btn3.Text="3";
        btnMultiplicacion.Text="*";
        btn0.Text="0";
        btnPunto.Text=".";
        btnIgual.Text="=";
        btnDivision.Text="/";
        
        // texto de los botones calculadora cientifica
        btnPi.Text="π";
        btLog.Text="log";
        btnSqrt.Text="√";
        btnCuadrado.Text="x²";
        btnSinh.Text="sinh";
        btnSin.Text="sin";
        btnDecimal.Text="Dec";
        btnXy.Text="^";
        btnCosh.Text="cosh";
        btnCos.Text="cos";
        btnBin.Text="Bin";
        btn1X.Text="1/x";
        btnTanh.Text="tanh";
        btnTan.Text="tan";
        btnHex.Text="Hex";
        btnLnx.Text="Ln x";
        btnExp.Text="Exp";
        btnMod.Text="Mod";
        btnOct.Text="Oct";
        btnFac.Text="n!";
        
        // texto de los items del menu
        catTipo.Text = "Tipo ▼";
        miEstandar.Text="Estandar";
        miCientifica.Text="Cientifica";

        //Posicion
        txtDisplay.Location=new Point(10,50);
        lblOperacion.Location=new Point(10,50);
        
        List<Button> lista = new List<Button>();
        lista.Add(btnBorrarUltimo);
        lista.Add(btnBorrarActual);
        lista.Add(btnBorrarTodo);
        lista.Add(btnSigno);
        lista.Add(btn7);
        lista.Add(btn8);
        lista.Add(btn9);
        lista.Add(btnSuma);
        lista.Add(btn4);
        lista.Add(btn5);
        lista.Add(btn6);
        lista.Add(btnResta);
        lista.Add(btn1);
        lista.Add(btn2);
        lista.Add(btn3);
        lista.Add(btnMultiplicacion);
        lista.Add(btn0);
        lista.Add(btnPunto);
        lista.Add(btnIgual);
        lista.Add(btnDivision);
        int x=10;
        int y=105;
        int count=0;
        foreach (Button btn in lista)
        {
            if(count==4){
                x=10;
                y+=67;
                count=0;
            }
            btn.Location=new Point(x,y);
            btn.Click+=new EventHandler(btn_click);
            this.Controls.Add(btn);
            x+=67;
            count++;
        }

        List<Button> cientifica = new List<Button>();
        cientifica.Add(btnPi);
        cientifica.Add(btLog);
        cientifica.Add(btnSqrt);
        cientifica.Add(btnCuadrado);
        cientifica.Add(btnSinh);
        cientifica.Add(btnSin);
        cientifica.Add(btnDecimal);
        cientifica.Add(btnXy);
        cientifica.Add(btnCosh);
        cientifica.Add(btnCos);
        cientifica.Add(btnBin);
        cientifica.Add(btn1X);
        cientifica.Add(btnTanh);
        cientifica.Add(btnTan);
        cientifica.Add(btnHex);
        cientifica.Add(btnLnx);
        cientifica.Add(btnExp);
        cientifica.Add(btnMod);
        cientifica.Add(btnOct);
        cientifica.Add(btnFac);
        x = 310;
        y = 105;
        count = 0;
        foreach (Button btn in cientifica)
        {
            if(count == 4){
                x = 310;
                y += 67;
                count = 0;
            }
            btn.Location=new Point(x,y);
            this.Controls.Add(btn);
            x+=67;
            count++;
        }
        
        // Eventos
        miEstandar.Click += new EventHandler(miEstandar_Click);
        miEstandar_Click(miEstandar, new EventArgs()); // por defecto muestra la calculadora estandar
        miCientifica.Click += new EventHandler(miCientifica_Click);
        btnPi.Click += new EventHandler(btnPi_Click);
        btLog.Click += new EventHandler(btnLog_Click);
        btnSqrt.Click += new EventHandler(btnRaiz_Click);
        btnCuadrado.Click += new EventHandler(btnCuadrado_Click);
        btnSinh.Click += new EventHandler(btnSinh_Click);
        btnSin.Click += new EventHandler(btnSin_Click);
        btnDecimal.Click += new EventHandler(btnDecimal_Click);
        btnXy.Click += new EventHandler(btn_click);
        btnCosh.Click += new EventHandler(btnCosh_Click);
        btnCos.Click += new EventHandler(btnCos_Click);
        btnBin.Click += new EventHandler(btnBinario_Click);
        btn1X.Click += new EventHandler(btn1X_Click);
        btnTanh.Click += new EventHandler(btnTanh_Click);
        btnTan.Click += new EventHandler(btnTan_Click);
        btnHex.Click += new EventHandler(btnHexadecimal_Click);
        btnLnx.Click += new EventHandler(btnLnx_Click);
        btnExp.Click += new EventHandler(btnExp_Click);
        btnMod.Click += new EventHandler(btn_click);
        btnOct.Click += new EventHandler(btnOctal_Click);
        btnFac.Click += new EventHandler(btnFactorial_Click);
        
        // Agregar controles al formulario
        this.Controls.Add(txtDisplay);
        this.Controls.Add(lblOperacion);
        catTipo.DropDownItems.Add(miEstandar);
        catTipo.DropDownItems.Add(miCientifica);
        menu.Items.Add(catTipo);
        this.Controls.Add(menu);
        this.Controls.Add(menu);
        lblOperacion.BringToFront();
    }

    private void miCientifica_Click(object? sender, EventArgs e)
    {
        this.Size = new Size(600, 500);
        txtDisplay.Size = new Size(558, 50);
    }

    private void miEstandar_Click(object? sender, EventArgs e)
    {
        this.Size = new Size(300, 500);
        txtDisplay.Size = new Size(260, 50);
    }

    private void btn_click(object? sender, EventArgs e){
        if(sender!=null){
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "⌫": 
                    if(txtDisplay.Text.Length>0)
                        txtDisplay.Text=txtDisplay.Text.Remove(txtDisplay.Text.Length-1,1);
                    if(txtDisplay.Text=="")
                        txtDisplay.Text="0";
                    break;
                case "CE": 
                    txtDisplay.Text="0";
                    break;
                case "C": 
                    txtDisplay.Text="0";
                    lblOperacion.Text="";
                    break;
                case "=": 
                    boton_igual();
                    break;
                case "±":
                    try
                    {
                        txtDisplay.Text=(Double.Parse(txtDisplay.Text)*-1).ToString(); 
                    }
                    catch (Exception exception)
                    {
                        txtDisplay.Text = "";
                        lblOperacion.Text = "";
                    }
                    break;
                case "0": case "1": case "2": case "3": case "4": case "5": case "6": case "7": case "8": case "9": case ".": 
                    boton_numero(btn.Text);
                    break;
                case "+": case "-": case "*": case "/": case "^": case "Mod":
                   boton_operador(btn.Text);
                   break;
            }
        }
    }

    private void boton_igual()
    {
        lblOperacion.Text+=" "+txtDisplay.Text+" =";
        switch (operacion)
        {
            case "+":
                txtDisplay.Text=(resultado+Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "-":
                txtDisplay.Text=(resultado-Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "*":
                txtDisplay.Text=(resultado*Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "/":
                txtDisplay.Text=(resultado/Double.Parse(txtDisplay.Text)).ToString();
                break;
            case "^":
                txtDisplay.Text=(Math.Pow(resultado,Double.Parse(txtDisplay.Text))).ToString();
                break;
            case "Mod":
                txtDisplay.Text=(resultado % Double.Parse(txtDisplay.Text)).ToString();
                break;
        }
    }

    private void boton_operador(string operador)
    {
        operacion=operador;
        resultado= Double.Parse(txtDisplay.Text);
        lblOperacion.Text=txtDisplay.Text+" "+operacion;
        txtDisplay.Text="0";
    }

    private void boton_numero(string valor)
    {
        if(txtDisplay.Text=="0"){
            txtDisplay.Text="";
        }
        if(valor=="."){
            if(!txtDisplay.Text.Contains(".")){
                txtDisplay.Text+=valor;
            }
        }
        else
        {
            txtDisplay.Text+=valor;
        }
    }
    
    // calcular pi
    private void btnPi_Click(object? sender, EventArgs e)
    {
        txtDisplay.Text = Math.PI + "";
    }
    
    // logaritmo base 10
    private void btnLog_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"Log10({txtDisplay.Text}) =";
            double numero = Double.Parse(txtDisplay.Text);
            if (numero > 0)
            {
                txtDisplay.Text = Math.Log10(numero) + "";
            }
            else
            {
                MessageBox.Show("Error: No se puede calcular el logaritmo de un número negativo",
                    "Error: Logaritmo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisplay.Text = "";
                lblOperacion.Text = "";
            }
        }
        catch (Exception exception)
        { 
            txtDisplay.Text = ""; 
            lblOperacion.Text = "";
        }
    }
    
    // raiz cuadrada
    private void btnRaiz_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"√({txtDisplay.Text}) ="; 
            double numero = Double.Parse(txtDisplay.Text); 
            if (numero >= 0) 
            { 
                txtDisplay.Text = Math.Sqrt(numero) + ""; 
            } 
            else 
            { 
                MessageBox.Show("Error: No se puede calcular la raíz cuadrada de un número negativo", 
                    "Error: Raíz Cuadrada", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                txtDisplay.Text = ""; 
                lblOperacion.Text = ""; 
            }
        }
        catch (Exception exception)
        {
           txtDisplay.Text = "";
           lblOperacion.Text = "";
        }
    }
    
    // calcular x^2
    private void btnCuadrado_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"({txtDisplay.Text})^2 =";
            double numero = Double.Parse(txtDisplay.Text);
            double cuadrado = Math.Pow(numero, 2);
            txtDisplay.Text = cuadrado + "";
        }
        catch (Exception exception)
        {
           txtDisplay.Text = "";
           lblOperacion.Text = "";
        }
    }
    
    // calcular seno hiperbolico
    private void btnSinh_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"senh({txtDisplay.Text}) =";
            double numero = Double.Parse(txtDisplay.Text);
            double senoh = Math.Sinh(numero);
            txtDisplay.Text = senoh + "";
        }
        catch (Exception exception)
        {
           txtDisplay.Text = "";
           lblOperacion.Text = "";
        }
    }
    
    // calcular seno
    private void btnSin_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"sin({txtDisplay.Text}) =";
            double numero = Double.Parse(txtDisplay.Text);
            // convertir el numero de grados a radianes
            double numRadianes = numero * Math.PI / 180;
            double seno = Math.Sin(numRadianes);
            txtDisplay.Text = seno + "";
        }
        catch (Exception exception)
        {
           txtDisplay.Text = "";
           lblOperacion.Text = "";
        }
    }
    
    // convertir de hexadecimal a decimal, de octal a decimal, de binario a decimal
    // TODO: terminar aun no funciona bien
    private void btnDecimal_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"{txtDisplay.Text} =";
            int numero = Convert.ToInt32(txtDisplay.Text, 16);
            txtDisplay.Text = numero + "";
        }
        catch (Exception exception)
        {
            try
            {
                lblOperacion.Text = $"{txtDisplay.Text} =";
                int numero = Convert.ToInt32(txtDisplay.Text, 8);
                txtDisplay.Text = numero + "";
            }
            catch (Exception exception2)
            {
                try
                {
                    lblOperacion.Text = $"{txtDisplay.Text} =";
                    int numero = Convert.ToInt32(txtDisplay.Text, 2);
                    txtDisplay.Text = numero + "";
                }
                catch (Exception exception3)
                {
                    txtDisplay.Text = "";
                    lblOperacion.Text = "";
                }
            }
        }
    }
    
    // calcular coseno hiperbolico
    private void btnCosh_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"cosh({txtDisplay.Text}) =";
            double numero = Double.Parse(txtDisplay.Text);
            double cosh = Math.Cosh(numero);
            txtDisplay.Text = cosh + "";
        }
        catch (Exception exception)
        {
           txtDisplay.Text = "";
           lblOperacion.Text = "";
        }
    }
    
    // calculara coseno
    private void btnCos_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"cos({txtDisplay.Text}) =";
            double numero = Double.Parse(txtDisplay.Text);
            // convertir el numero de grados a radianes
            double numRadianes = numero * Math.PI / 180;
            double coseno = Math.Cos(numRadianes);
            txtDisplay.Text = coseno + "";
        }
        catch (Exception exception)
        {
           txtDisplay.Text = "";
           lblOperacion.Text = "";
        }
    }
    
    // convertir a binario
    // TODO: terminar aun no funciona bien
    private void btnBinario_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"Bin = {Convert.ToString(Convert.ToInt32(txtDisplay.Text), 2)} \n";
            lblOperacion.Text += $"Hex = {Convert.ToString(Convert.ToInt32(txtDisplay.Text), 16)} \n";
            lblOperacion.Text += $"Oct = {Convert.ToString(Convert.ToInt32(txtDisplay.Text), 8)}";
            
        }
        catch (Exception exception)
        { 
            MessageBox.Show("Error: No se puede realizar la conversión, valor no válido",
                "Error: Conversión Binario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtDisplay.Text = ""; 
            lblOperacion.Text = "";
        }
    }
    
    // calcular 1/x
    private void btn1X_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"1/{txtDisplay.Text} =";
            double numero = Double.Parse(txtDisplay.Text);
            double inversa = 1 / numero;
            txtDisplay.Text = inversa + "";
        }
        catch (Exception exception)
        {
           txtDisplay.Text = "";
           lblOperacion.Text = "";
        }
    }
    
    // calcular tangente hiperbolica
    private void btnTanh_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"tanh({txtDisplay.Text}) =";
            double numero = Double.Parse(txtDisplay.Text);
            double tangente = Math.Tanh(numero);
            txtDisplay.Text = tangente + "";
        }
        catch (Exception exception)
        {
           txtDisplay.Text = "";
           lblOperacion.Text = "";
        }
    }
    
    //calcular tangente
    private void btnTan_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"tan({txtDisplay.Text}) =";
            double numero = Double.Parse(txtDisplay.Text);
            // convertir el numero de grados a radianes
            double numRadianes = numero * Math.PI / 180;
            double tangente = Math.Tan(numRadianes);
            txtDisplay.Text = tangente + "";
        }
        catch (Exception exception)
        {
           txtDisplay.Text = "";
           lblOperacion.Text = "";
        }
    }
    
    // convertir a hexadecimal
    // TODO: terminar aun no funciona bien
    private void btnHexadecimal_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"Hex({txtDisplay.Text}) = ";
            txtDisplay.Text = Convert.ToString(Convert.ToInt32(txtDisplay.Text, 10), 16);
        }
        catch (Exception exception)
        { 
            MessageBox.Show("Error: No se puede realizar la conversión, valor no válido",
                "Error: Conversión Hexadecimal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtDisplay.Text = ""; 
            lblOperacion.Text = "";
        }
    }
    
    // calcular logaritmo natural de X
    private void btnLnx_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"Ln({txtDisplay.Text}) =";
            double numero = Double.Parse(txtDisplay.Text);
            double logaritmo = Math.Log(numero);
            txtDisplay.Text = logaritmo + "";
        }
        catch (Exception exception)
        {
           txtDisplay.Text = "";
           lblOperacion.Text = "";
        }
    }
    
    // calcular Exp
    private void btnExp_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"Exp({txtDisplay.Text}) =";
            double numero = Double.Parse(txtDisplay.Text);
            double exponencial = Math.Exp(numero);
            txtDisplay.Text = exponencial + "";
        }
        catch (Exception exception)
        {
           txtDisplay.Text = "";
           lblOperacion.Text = "";
        }
    }
    
    // convertir a octal
    // TODO: terminar aun no funciona bien
    private void btnOctal_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"Oct({txtDisplay.Text}) = ";
            txtDisplay.Text = Convert.ToString(Convert.ToInt32(txtDisplay.Text, 10), 8);
        }
        catch (Exception exception)
        { 
            MessageBox.Show("Error: No se puede realizar la conversión, valor no válido",
                "Error: Conversión Octal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtDisplay.Text = ""; 
            lblOperacion.Text = "";
        }
    }
    
    // calcular factorial
    private void btnFactorial_Click(object? sender, EventArgs e)
    {
        try
        {
            lblOperacion.Text = $"{txtDisplay.Text}!";
            double numero = Double.Parse(txtDisplay.Text);
            double factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            txtDisplay.Text = factorial + "";
        }
        catch (Exception exception)
        {
           txtDisplay.Text = "";
           lblOperacion.Text = "";
        }
    }
    
}