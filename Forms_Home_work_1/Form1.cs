using System.Windows.Forms;

namespace Forms_Home_work_1
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            int min = 0, middle = 50, max = 100;
            MessageBox.Show("��������� ����� �� 1 �� 100", "������ ������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int TryCount = 0;
            do
            {
                ++TryCount;
                var result = MessageBox.Show($"���� ����� ������ {middle}", $"���������� ������� {TryCount}", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    min = middle;
                    middle = max - (max - min) / 2;
                }
                else if (result == DialogResult.No)
                {
                    max = middle;
                    middle = min + ((max - min) / 2);
                }
                result = MessageBox.Show($"���� ����� {middle}", $"���������� ������� {TryCount}", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"���, ���, ��� ����� ������� {TryCount}", "������", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                }
            } while (true);

        }
        #endregion


    }
}