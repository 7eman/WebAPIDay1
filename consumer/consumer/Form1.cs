namespace consumer
{
    public partial class Form1 : Form
    {
        HttpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7263/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage resp = client.GetAsync("https://localhost:7263/api/Course").Result;
            if (resp.IsSuccessStatusCode)
            {
                List<course_data> crs = resp.Content.ReadAsAsync<List<course_data>>().Result;
                course_dgv.DataSource = crs;

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            course_data crs = new course_data()
            {
               Crs_name = txt_name.Text,
                 Crs_desc = txt_desc.Text,
                Duration=int.Parse(txt_duration.Text)
            };
            HttpResponseMessage resp = client.PostAsJsonAsync("api/Course", crs).Result;
            if (resp.IsSuccessStatusCode)
            {

                Form1_Load(null, null);
                txt_duration.Text = txt_desc.Text= txt_name.Text= "";
                MessageBox.Show("added");
            }
        }
    }
}
