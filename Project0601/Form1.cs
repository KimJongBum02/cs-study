using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project0601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string currentFilePath = ""; // 현재 파일 경로를 저장하는 전역 변수.
        bool isModified = false; // txtMemo.Text의 변경사항이 있는지 확인하는 플래그
        private void UpdateTile()
        {
            bool chk = string.IsNullOrEmpty(currentFilePath);
            if (chk == true)
            {
                this.Text = "제목없음 - 메모장";
            }
            else
            {
                this.Text = currentFilePath;
            }
        }
        private bool SaveAsFile()
        {
            saveFileDialog1.Title = "텍스트문서 다른이름으로 저장...";
            saveFileDialog1.Filter = "텍스트문서|*.txt|모든파일|*.*";
            saveFileDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                // 파일 저장
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(txtMemo.Text);
                sw.Close();

                currentFilePath = saveFileDialog1.FileName;
                isModified = false;
                UpdateTile();
                return true;
            }

            return false;
        }

        private bool checkSaveBeforeContinue()
        {
            if (!isModified)
            {
                return true;
            }

            DialogResult result = 
                MessageBox.Show("내용이 수정되었습니다. 저장 하시겠습니까 ?", "저장확인",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                return SaveAsFile(); // 예 버튼 클릭 시
            }
            else if (result == DialogResult.Cancel)
            {
                return false; // 취소 버튼 클릭 시
            }

            return true; // 아니오 버튼 클릭 시
        }
        private void mnuNew_Click(object sender, EventArgs e)
        {
            // 수정사항 체크
            if (checkSaveBeforeContinue())
            {
                return;
            }

            // 새 파일 생성
            txtMemo.Clear();
            currentFilePath = "";
            isModified = false;
            UpdateTile();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (!checkSaveBeforeContinue())
            {
                return;
            }

            openFileDialog1.Title = "텍스트문서 열기";
            openFileDialog1.Filter = "텍스트문서|*.txt|모든파일|*.*";
            DialogResult result =
                openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamReader sr =
                    new StreamReader(openFileDialog1.FileName);
                txtMemo.Text = sr.ReadToEnd();
                sr.Close();

                currentFilePath = openFileDialog1.FileName;
                isModified = false;
                UpdateTile();
            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("다음에 또 만나요", "안녕",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void txtMemo_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {

        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            txtMemo.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            txtMemo.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            txtMemo.Paste();
        }
    }
}
