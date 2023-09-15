using System.Collections.Generic;

namespace AmazonDoMilhao;

public partial class Home : Form
{
    
    public Home()
    {
        InitializeComponent();
        Static.References = GetReferences();

        buttonArquivoSaida.Enabled = false;
        buttonGerarArquivoDeSaida.Enabled = false;
    }

    private List<References> GetReferences()
    {
        var references = new List<References>();

        string path = Application.StartupPath + "/references.bin";
        var reader = new StreamReader(path);
        var refs = reader.ReadToEnd();
        var refSplitted = refs.Split('\n');
        
        foreach(string line in refSplitted)
        {
            var allItems = line.Replace("\r", "");
            string[] items = allItems.Split(',');
            if (items.Length < 4) continue;

            references.Add(new(items[0], items[1], items[2], items[3]));
            dataGridViewReferencias.Rows.Add(items);
        }

        dataGridViewReferencias.Columns[3].Width = 400;
        return references;
    }

    private void Mensagem(string text)
    {
        MessageBox.Show(text, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void Erro(string text)
    {
        MessageBox.Show(text, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void buttonArquivoEntrada_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialogEntrada = new OpenFileDialog();
        openFileDialogEntrada.Filter = "(*.txt)|*.txt";

        DialogResult result = openFileDialogEntrada.ShowDialog(this);
        if (result != DialogResult.OK) return;

        textBoxArquivoEntrada.Text = openFileDialogEntrada.FileName;

        bool b = AbreArquivoDeEntrada(openFileDialogEntrada.FileName);
        if (!b)
        {
            Erro("Algo deu errado, erro ao tentar ler arquivo.");
            return;
        }

        buttonArquivoSaida.Enabled = true;
    }

    private bool AbreArquivoDeEntrada(string fileName)
    {
        string arquivo = string.Empty;

        try
        {
            arquivo = File.ReadAllText(fileName);
        }
        catch (Exception ex)
        { 
            Erro(ex.Message); 
            return false;
        }

        if (string.IsNullOrWhiteSpace(arquivo)) return false;

        bool b = ChecaSeArquivoEstaCorreto(arquivo, out string[] linesArray);
        if (!b) return false;

        Static.LinesArray = linesArray;

        return true;
    }

    private bool ChecaSeArquivoEstaCorreto(string arquivo, out string[] arrayLines)
    {
        arrayLines = arquivo.Split('\n');
        if (arrayLines.Length == 0) return false;

        return true;
    }

    private void buttonArquivoSaida_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialogSaida = new SaveFileDialog();
        saveFileDialogSaida.Filter = "(*.csv)|*.csv";

        DialogResult result = saveFileDialogSaida.ShowDialog(this);
        if (result != DialogResult.OK) return;

        textBoxArquivoSaida.Text = saveFileDialogSaida.FileName;

        buttonGerarArquivoDeSaida.Enabled = true;
    }

    private void buttonGerarArquivoDeSaida_Click(object sender, EventArgs e)
    {
        buttonGerarArquivoDeSaida.Enabled = false;
        try
        {
           string csv = Static.GeraCSV();

            var writer = new StreamWriter(textBoxArquivoSaida.Text, false);
            writer.Write(csv);
            writer.Close();

            Mensagem("Arquivo gerado com sucesso!");
            buttonGerarArquivoDeSaida.Enabled = true;
        }
        catch(Exception ex)
        {
            Erro(ex.Message);
        }
    }
}
