using ImagePicker.Properties;

namespace ImagePicker;

public partial class Form1 : Form
{
    private Bitmap _myImage;
    private OpenFileDialog _ofd;
    private string SelectedPath
    {
        get
        {
            return Settings.Default.SelectedPath;
        }
        set
        {
            Settings.Default.SelectedPath = value;
        }
    }
    public Form1()
    {
        InitializeComponent();
        _ofd = new OpenFileDialog();
        InitializePictureComponent();
    }

    private void InitializePictureComponent()
    {
        _ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.svg;*.bmp";
        if (SelectedPath != "")
        {
            _myImage = new Bitmap(SelectedPath);
            label1.Text = SelectedPath;
            pictureBox1.Image = _myImage;
            button2.Visible = true;
        }
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
    }
    
    private void button1_Click_1(object sender, EventArgs e)
    {
        string path;
        try
        {
            if (_ofd.ShowDialog() == DialogResult.OK)
            {
                _myImage = new Bitmap(_ofd.FileName);
                path = $"{_ofd.InitialDirectory}{_ofd.FileName}";
                label1.Text = path;
                pictureBox1.Image = _myImage;
                button2.Visible = true;
                SelectedPath = path;
                Settings.Default.Save();
            }
        }
        catch (Exception exception)
        {
            MessageBox.Show($"{exception.Message}/Nieprawidłowy format");
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        label1.Text = null;
        pictureBox1.Image = null;
        button2.Visible = false;
        
        SelectedPath = "";
        Settings.Default.Save();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
    }
}