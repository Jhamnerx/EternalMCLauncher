using Microsoft.VisualBasic;
using System.IO.Compression;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using Newtonsoft.Json;
using eternalModpackInstaller.Models;
using System.Windows.Shapes;
using Microsoft.VisualBasic.Devices;
using System;
using eternalModpackInstaller.Properties;
using System.Resources;
using MaterialSkin.Properties;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Media.Media3D;


namespace eternalModpackInstaller
{
    public partial class FormularioInicial : Form
    {
        public string _pathBase = System.Reflection.Assembly.GetExecutingAssembly().Location;
        //public string _path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
        public FormularioInicial()
        {
            InitializeComponent();
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            // Install(0);
            string path_multiminecraft = Environment.ExpandEnvironmentVariables("%appdata%/MC/MultiMinecraft");
            string path_roaming = Environment.ExpandEnvironmentVariables("%appdata%/.minecraft");

            string path = getPathResource("minecraft.zip");
            Boolean exist = verifyFileExists(path);


            if (cboPathInstall.SelectedIndex == 0)
            {
                if (verifyInstalledMultiMinecraft(path_multiminecraft))
                {
                    //MessageBox.Show("MultiMinecraft2 esta Instalado", "MultiMinecraft2 encontrado");
                    if (exist)
                    {

                        if (backgroundWorker1.IsBusy != true)
                        {
                            loader.Visible = true;
                            backgroundWorker1.RunWorkerAsync(cboPathInstall.SelectedIndex);

                        }
                        else
                        {
                            //txtPrueba.Text = "Ya se encuentra extrayendo el zip";
                        }

                    }
                    else
                    {
                        MsgBoxResult.Ok.Equals(MsgBoxResult.Ok);
                        MessageBox.Show("No se encontro el archivo requerido", "Archivo no Existe");
                    }
                }
                else
                {
                    MessageBox.Show("MultiMinecraft2 No esta Instalado", "MultiMinecraft2 No encontrado");
                }

            }
            else
            {
                if (verifyInstalledRoaming(path_roaming))
                {
                    if (exist)
                    {

                        if (backgroundWorker1.IsBusy != true)
                        {
                            loader.Visible = true;
                            backgroundWorker1.RunWorkerAsync(cboPathInstall.SelectedIndex);

                        }
                        else
                        {
                            //txtPrueba.Text = "Ya se encuentra extrayendo el zip";
                        }

                    }
                    else
                    {
                        MsgBoxResult.Ok.Equals(MsgBoxResult.Ok);
                        MessageBox.Show("No se encontró el archivo requerido", "Archivo no Existe");
                    }
                }
                else
                {
                    MessageBox.Show("Ya hay una instalación en Roaming", "Error al instalar");
                }

            }



        }

        public void Install(int folder = 1)
        {
            string path_multiminecraft = Environment.ExpandEnvironmentVariables("%appdata%/MC/MultiMinecraft/instancias");
            string path_instancias = Environment.ExpandEnvironmentVariables("%appdata%/MC/MultiMinecraft/system/instancias");
            string path_roaming = Environment.ExpandEnvironmentVariables("%appdata%");

            try
            {
                if (folder == 0)
                {
                    List<string> instancias = new List<string>();

                    string[] directorios_full = Directory.GetDirectories(path_instancias, "*");
                    int max_instancia = 0;

                    if (directorios_full.Length != 0)
                    {

                        foreach (string dir in directorios_full)
                        {
                            DirectoryInfo d = new DirectoryInfo(dir);
                            instancias.Add(d.Name);

                        }
                        // txtPrueba.Text = instancias.Max()+" -"+instancias.Count;
                        int v = int.Parse(instancias.Max()) + 1;
                        max_instancia = v;

                    }
                    else
                    {
                        int v = int.Parse(instancias.Max()) + 1;
                        max_instancia = v;

                    }

                    string path = getPathResource("minecraft.zip");
                    ZipFile.ExtractToDirectory(path, path_multiminecraft + "/" + max_instancia, System.Text.Encoding.UTF8, true);

                    createInstancia(path_instancias, max_instancia);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo extraer el paquete de mods: " + ex.Message);
            }
        }


        public static void createInstancia(string path, int max_instancia)
        {

            try
            {
                var datosFromFile = getDatosJsonFromFile();
                Datos datos = getDatos(datosFromFile);

                Instancia instancia = new Instancia();
                instancia.Nombre = datos.Name;
                instancia.Icono = "art-Creeper";

                string InstanciaJSon = JsonConvert.SerializeObject(instancia);
                Directory.CreateDirectory(path + "/" + max_instancia);
                File.WriteAllText(path + "/" + max_instancia + "/Instancia.json", InstanciaJSon);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* 
            string sourceDirectory = @"./";


            var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*");

            foreach (string currentFile in txtFiles)
    




                comboBox1.Items.Add(currentFile);
            }*/

            verifyFileExists(getPathResource("minecraft.zip"));

            var datosFromFile = getDatosJsonFromFile();
            Datos datos = getDatos(datosFromFile);
            setDatosToForm(datos);
            setRedesImagenes(datos);

        }

        public bool verifyInstalledMultiMinecraft(string path)
        {
            bool exists = false;

            if (!Directory.Exists(path))
            {

                exists = false;
            }
            else
            {

                exists = true;
            }

            return exists;

        }
        public bool verifyInstalledRoaming(string path)
        {
            bool exists = false;

            if (!Directory.Exists(path))
            {

                exists = false;
            }
            else
            {

                exists = true;
            }

            return exists;

        }

        public void setDatosToForm(Datos datos)
        {
            var resources = new ResourceManager(typeof(FormularioInicial));

            var directory = System.IO.Path.GetDirectoryName(_pathBase);

            this.Text = datos.Titulo + " V." + datos.Version;


            string path_fondo = getPathResource(datos.Imagenes.Fondo); ;

            if (verifyFileExists(path_fondo))
            {

                this.BackgroundImage = (Image)new Bitmap(path_fondo);
            }
            else
            {
                this.BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            }

            string path_logo = getPathResource(datos.Imagenes.Logo);



            if (verifyFileExists(path_logo))
            {
                try
                {

                    this.logo.Image = (Image)new Bitmap(path_logo);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
            else
            {
                this.logo.Image = (Image)resources.GetObject("pictureBox1.Image");
            }
        }

        private bool verifyFileExists(String file)
        {
            bool file_exists = false;

            if (!File.Exists(file))
            {

                file_exists = false;
            }
            else
            {

                file_exists = true;
            }

            return file_exists;
        }

        public static string getDatosJsonFromFile()
        {
            var resources = new ResourceManager(typeof(FormularioInicial));
            string path = getPathResource("datos.json");
            string Datos;

            if (!File.Exists(path))
            {
                string path_json = getPathResource("datos.json");

                using (var reader = new StreamReader(path_json))
                {
                    Datos = reader.ReadToEnd();
                }
                return Datos;

            }
            else
            {
                try
                {

                    using (var reader = new StreamReader(path))
                    {
                        Datos = reader.ReadToEnd();
                    }
                    return Datos;

                }
                catch (Exception)
                {
                    return "{}";

                }
            }



        }

        public static Datos getDatos(string jsonFile)
        {
            try
            {
                var datos = JsonConvert.DeserializeObject<Datos>(jsonFile);
                return datos;

            }
            catch (Exception)
            {
                return null;

            }

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int value = (int)e.Argument;
            Install(value);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            loader.Visible = false;
            MessageBox.Show("Se ha completado la instalación", "Finalizado");
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        public static string getPathResource(string file)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string filePath = System.IO.Path.Combine(currentDirectory, "Resources", file);

            return filePath;
        }

        public void setRedesImagenes(Datos datos)
        {
            //textBox1.Text = datos.Redes.Facebook.link;

            if (datos.Redes.Facebook.activo)
            {
                try
                {
                    this.RedFacebook.Image = (Image)new Bitmap(getPathResource("redes/" + datos.Redes.Facebook.img));
                }
                catch
                {
                    this.RedFacebook.Image = null;
                    this.RedFacebook.Cursor = Cursors.Default;
                }


            }
            else
            {
                this.RedFacebook.Visible = false;
                this.RedFacebook.Cursor = Cursors.Default;
            }

            if (datos.Redes.tiktok.activo)
            {
                this.RedTiktok.Image = (Image)new Bitmap(getPathResource("redes/" + datos.Redes.tiktok.img));
            }
            else
            {
                this.RedTiktok.Visible = false;
                this.RedTiktok.Cursor = Cursors.Default;
            }

            if (datos.Redes.twitter.activo)
            {
                try
                {
                    this.RedTwitter.Image = (Image)new Bitmap(getPathResource("redes/" + datos.Redes.twitter.img));
                }
                catch
                {
                    this.RedTwitter.Visible = false;
                    this.RedTwitter.Image = null;
                    this.RedTwitter.Cursor = Cursors.Default;
                }

            }
            else
            {
                this.RedTwitter.Cursor = Cursors.Default;
            }

            if (datos.Redes.youtube.activo)
            {
                try
                {
                    this.RedYoutube.Image = (Image)new Bitmap(getPathResource("redes/" + datos.Redes.youtube.img));
                }
                catch
                {
                    this.RedYoutube.Visible = false;
                    this.RedYoutube.Image = null;
                    this.RedYoutube.Cursor = Cursors.Default;
                }

            }
            else
            {
                this.RedYoutube.Visible = false;
                this.RedYoutube.Cursor = Cursors.Default;
            }

            if (datos.Redes.twitch.activo)
            {
                try
                {
                    this.RedTwitch.Image = (Image)new Bitmap(getPathResource("redes/" + datos.Redes.twitch.img));
                }
                catch
                {
                    this.RedTwitch.Visible = false;
                    this.RedTwitch.Image = null;
                    this.RedTwitch.Cursor = Cursors.Default;
                }

            }
            else
            {
                this.RedTwitch.Cursor = Cursors.Default;
            }

        }



        public bool StartWebLink(string url)
        {
            try
            {
                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psInfo);
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }
        private void RedFacebook_Click(object sender, EventArgs e)
        {
            var datosFromFile = getDatosJsonFromFile();
            Datos datos = getDatos(datosFromFile);
            StartWebLink(datos.Redes.Facebook.link);

        }
        private void RedTiktok_Click(object sender, EventArgs e)
        {
            var datosFromFile = getDatosJsonFromFile();
            Datos datos = getDatos(datosFromFile);
            StartWebLink(datos.Redes.tiktok.link);
        }


        private void RedTwitter_Click(object sender, EventArgs e)
        {
            var datosFromFile = getDatosJsonFromFile();
            Datos datos = getDatos(datosFromFile);
            StartWebLink(datos.Redes.twitter.link);

        }

        private void RedYoutube_Click(object sender, EventArgs e)
        {
            var datosFromFile = getDatosJsonFromFile();
            Datos datos = getDatos(datosFromFile);
            StartWebLink(datos.Redes.youtube.link);

        }

        private void RedTwitch_Click(object sender, EventArgs e)
        {

            var datosFromFile = getDatosJsonFromFile();
            Datos datos = getDatos(datosFromFile);
            StartWebLink(datos.Redes.twitch.link);

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string path = getPathResource("datos.json");


        //}
    }
}