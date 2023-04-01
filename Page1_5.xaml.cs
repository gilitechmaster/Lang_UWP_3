using System;
using System.IO;
using Xamarin.Forms;

using Xamarin.Forms.Xaml;

namespace Lang_UWP_3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e) //저장버튼 누르면
        {
            var note = (Note)BindingContext;

            if (string.IsNullOrWhiteSpace(note.Filename)) //문자열이 널인지 공백인지 확인한다.
            {
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(filename, note.Text);
            }
            else
            {
                File.WriteAllText(note.Filename, note.Text);
            }
            await Navigation.PopAsync();
        }

        async void OnCalc1ButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;

            if (string.IsNullOrWhiteSpace(note.Filename))
            {
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(filename, note.Text);
            }

            else
            {
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(note.Filename, note.Text);
                StreamWriter sw = new StreamWriter(filename, true);
                string[] arr = note.Text.Split(new string[]{

                    ". ",  // 순차처리하므로 ". "를 앞에해두어야 한다.
                    ".",
                    ", ",
                    ",",
                    "? ",
                    "?",
                    "! ",
                    "!",
                    "·", // 법률문서에 사용되는 기호
                    " "

                        }, StringSplitOptions.None);


                foreach (string B in arr)
                {
                    sw.WriteLine(B);

                    if (B.Contains("\n")  // replace로 2차처리
                        )
                        sw.WriteLine("{0}", B
                          .Replace("\n", "")
                          );
                }

                sw.Close();

            }

            await Navigation.PopAsync();
        }

        async void OnCalc2ButtonClicked(object sender, EventArgs e) // 개체분해버튼
        {
            var note = (Note)BindingContext;

            if (string.IsNullOrWhiteSpace(note.Filename))
            {
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(filename, note.Text);
            }

            else
            {
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(note.Filename, note.Text);
                StreamWriter sw = new StreamWriter(filename, true);
                string[] arr = note.Text.Split(new string[]{

                    ". ",  // 순차처리하므로 ". "를 앞에해두어야 한다.
                    ".",
                    ", ",
                    ",",
                    "? ",
                    "?",
                    "! ",
                    "!",
                    "·", // 법률문서에 사용되는 기호
                    " "

                        }, StringSplitOptions.None);

                foreach (string B in arr)
                {

                    //sw.WriteLine(B);

                    // 개체 + 에너지 = 1최소요소 = NXET
                    // 개체 = N
                    // 기호 = X
                    // 에너지 = E
                    // 시간 = T
                    // 1최소요소는 절대요소이다.

                    if (B.EndsWith("가족") == true)
                        sw.WriteLine("{0}", B
                            .Replace("가족", "N")
                            );
                    if (B.EndsWith("경제") == true)
                        sw.WriteLine("{0}", B
                            .Replace("경제", "N")
                            );
                    if (B.EndsWith("민족") == true) // 개체
                        sw.WriteLine("{0}", B
                            .Replace("민족", "N")
                            );
                    if (B.EndsWith("물질") == true)
                        sw.WriteLine("{0}", B
                            .Replace("물질", "N")
                            );
                    if (B.EndsWith("문화") == true)
                        sw.WriteLine("{0}", B
                            .Replace("문화", "N")
                            );
                    if (B.EndsWith("법률") == true)
                        sw.WriteLine("{0}", B
                            .Replace("환경", "N")
                            );
                    if (B.EndsWith("사회") == true)
                        sw.WriteLine("{0}", B
                            .Replace("사회", "N")
                            );
                    if (B.EndsWith("사과") == true)
                        sw.WriteLine("{0}", B
                            .Replace("사과", "N")
                            );
                    if (B.EndsWith("사람") == true)
                        sw.WriteLine("{0}", B
                            .Replace("사람", "N")
                            );
                    if (B.EndsWith("인간") == true)
                        sw.WriteLine("{0}", B
                            .Replace("인간", "N")
                            );
                    if (B.EndsWith("연구") == true)
                        sw.WriteLine("{0}", B
                            .Replace("연구", "N")
                            );
                    if (B.EndsWith("역사") == true)
                        sw.WriteLine("{0}", B
                            .Replace("역사", "N")
                            );
                    if (B.EndsWith("정치") == true)
                        sw.WriteLine("{0}", B
                            .Replace("정치", "N")
                            );
                    if (B.EndsWith("조직") == true)
                        sw.WriteLine("{0}", B
                            .Replace("조직", "N")
                            );
                    if (B.EndsWith("집단") == true)
                        sw.WriteLine("{0}", B
                            .Replace("집단", "N")
                            );
                    if (B.EndsWith("자연") == true)
                        sw.WriteLine("{0}", B
                            .Replace("집단", "N")
                            );
                    if (B.EndsWith("지리") == true)
                        sw.WriteLine("{0}", B
                            .Replace("지리", "N")
                            );
                    if (B.EndsWith("제도") == true)
                        sw.WriteLine("{0}", B
                            .Replace("제도", "N")
                            );
                    if (B.EndsWith("체질") == true)
                        sw.WriteLine("{0}", B
                            .Replace("체질", "N")
                            );
                    if (B.EndsWith("친족") == true)
                        sw.WriteLine("{0}", B
                            .Replace("친족", "N")
                            );
                    if (B.EndsWith("특성") == true)
                        sw.WriteLine("{0}", B
                            .Replace("특성", "N")
                            );
                    if (B.EndsWith("학자") == true)
                        sw.WriteLine("{0}", B
                            .Replace("학자", "N")
                            );
                    if (B.EndsWith("환경") == true)
                        sw.WriteLine("{0}", B
                            .Replace("환경", "N")
                            );
                    if (B.EndsWith("혼인") == true)
                        sw.WriteLine("{0}", B
                            .Replace("혼인", "N")
                            );

                }
                sw.Close();

            }

            await Navigation.PopAsync();
        }

        async void OnCalc3ButtonClicked(object sender, EventArgs e) // 에너지분해버튼
        {
            var note = (Note)BindingContext;

            if (string.IsNullOrWhiteSpace(note.Filename))
            {
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(filename, note.Text);
            }

            else
            {
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(note.Filename, note.Text);
                StreamWriter sw = new StreamWriter(filename, true);
                string[] arr = note.Text.Split(new string[]{

                    ". ",  // 순차처리하므로 ". "를 앞에해두어야 한다.
                    ".",
                    ", ",
                    ",",
                    "? ",
                    "?",
                    "! ",
                    "!",
                    "·", // 법률문서에 사용되는 기호
                    " "

                        }, StringSplitOptions.None);

                foreach (string B in arr)
                {

                    //sw.WriteLine(B);

                    // 개체 + 에너지 = 1최소요소 = NXET
                    // 개체 = N
                    // 기호 = X
                    // 에너지 = E
                    // 시간 = T
                    // 1최소요소는 절대요소이다.

                    if (B.StartsWith("있") == true) // 에너지
                        sw.WriteLine("{0}", B

                            .Replace("있다", "있")
                            .Replace("있", "E")
                            );

                    if (B.StartsWith("없") == true) // 에너지
                        sw.WriteLine("{0}", B

                            .Replace("없다", "없")
                            .Replace("없", "E")
                            );

                    if (B.EndsWith("큰") == true) // 에너지
                        sw.WriteLine("{0}", B

                            .Replace("큰", "크ㄴ")
                            .Replace("크ㄴ", "크")
                            .Replace("크", "E")
                            );

                    if (B.LastIndexOf("반응") >= 0) // 에너지

                        sw.WriteLine("{0}", B
                            .Replace("반응", "거꿀다+응하다")
                            .Replace("거꿀다+응하다", "EE")
                            );

                    // 개체의 명제에 있어서
                    // 개와 체 = 셀 수 있는 존재의 집합
                    // 반응은 셀 수 없음으로
                    // 명사로 소속되어도 동사로
                    // 해체가 가능해진다.
                    // 에너지 = 동사 = 행동
                    // 명사 = 개체 = 존재

                    if (B.LastIndexOf("학") >= 0) // 에너지
                        sw.WriteLine("{0}", B
                            .Replace("화학", "되다+연구하다, EE")
                            );

                }
                sw.Close();

            }

            await Navigation.PopAsync();
        }

        async void OnCalc4ButtonClicked(object sender, EventArgs e) // 에너지분해버튼
        {
            var note = (Note)BindingContext;

            if (string.IsNullOrWhiteSpace(note.Filename))
            {
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(filename, note.Text);
            }

            else
            {
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(note.Filename, note.Text);
                StreamWriter sw = new StreamWriter(filename, true);
                string[] arr = note.Text.Split(new string[]{

                    ". ",  // 순차처리하므로 ". "를 앞에해두어야 한다.
                    ".",
                    ", ",
                    ",",
                    "? ",
                    "?",
                    "! ",
                    "!",
                    "·", // 법률문서에 사용되는 기호
                    " "

                        }, StringSplitOptions.None);

                foreach (string B in arr)
                {

                    //sw.WriteLine(B);

                    // 개체 + 에너지 = 1최소요소 = NXET
                    // 개체 = N
                    // 기호 = X
                    // 에너지 = E
                    // 시간 = T
                    // 1최소요소는 절대요소이다.


                    if (B.EndsWith("가") == true) // 기호
                        sw.WriteLine("{0}", B
                        .Replace("가", "X")
                        );

                    if (B.EndsWith("는") == true) // 기호
                        sw.WriteLine("{0}", B
                        .Replace("또는", "X")
                        .Replace("는", "X")
                        );

                    if (B.EndsWith("를") == true) // 기호
                        sw.WriteLine("{0}", B
                        .Replace("를", "X")
                        );

                    if (B.EndsWith("및") == true) // 기호
                        sw.WriteLine("{0}", B
                        .Replace("및", "X")
                        );

                    if (B.EndsWith("서") == true) // 기호
                        sw.WriteLine("{0}", B
                        .Replace("에서", "서")
                        .Replace("서", "X")
                        );

                    if (B.EndsWith("은") == true) // 기호
                        sw.WriteLine("{0}", B
                        .Replace("은", "X")
                        );

                    if (B.EndsWith("을") == true) // 기호
                        sw.WriteLine("{0}", B
                        .Replace("을", "X")
                        );

                    if (B.EndsWith("이") == true) // 기호
                        sw.WriteLine("{0}", B
                        .Replace("이", "X")
                        );

                    if (B.EndsWith("의") == true) // 기호
                        sw.WriteLine("{0}", B
                        .Replace("의", "X")
                        );

                }
                sw.Close();
            }

            await Navigation.PopAsync();
        }

        async void OnCalc5ButtonClicked(object sender, EventArgs e) // 종합분해버튼
        {
            var note = (Note)BindingContext;

            if (string.IsNullOrWhiteSpace(note.Filename))
            {
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(filename, note.Text);
            }

            else
            {
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(note.Filename, note.Text);
                StreamWriter sw = new StreamWriter(filename, true);
                string[] arr = note.Text.Split(new string[]{

                    ". ",  // 순차처리하므로 ". "를 앞에해두어야 한다.
                    ".",
                    ", ",
                    ",",
                    "? ",
                    "?",
                    "! ",
                    "!",
                    "·", // 법률문서에 사용되는 기호
                    " "

                        }, StringSplitOptions.None);

                foreach (string B in arr)
                {

                    //sw.WriteLine(B);

                    // 개체 + 에너지 = 1최소요소 = NXET
                    // 개체 = N
                    // 기호 = X
                    // 에너지 = E
                    // 시간 = T
                    // 1최소요소는 절대요소이다.

                    if (B.LastIndexOf("오늘") >= 0) // 시간
                        sw.WriteLine("{0}", B
                        .Replace("오늘", "T")
                        );

                }
                sw.Close();
            }

            await Navigation.PopAsync();
        }

        async void OnCalc6ButtonClicked(object sender, EventArgs e) // 종합분해버튼
        {
            var note = (Note)BindingContext;

            if (string.IsNullOrWhiteSpace(note.Filename))
            {
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(filename, note.Text);
            }

            else
            {
                var filename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.notes.txt");
                File.WriteAllText(note.Filename, note.Text);
                StreamWriter sw = new StreamWriter(filename, true);
                string[] arr = note.Text.Split(new string[]{

                    ". ",  // 순차처리하므로 ". "를 앞에해두어야 한다.
                    ".",
                    ", ",
                    ",",
                    "? ",
                    "?",
                    "! ",
                    "!",
                    "·", // 법률문서에 사용되는 기호
                    " "

                        }, StringSplitOptions.None);

                foreach (string B in arr)
                {

                    sw.WriteLine(B);

                    // 종합버튼은 작업이 헷갈리므로
                    // 다른 프로그램 혹은 다음에 종합한다.

                    // 종합버튼 = 개체 + 기호 + 에너지 + 시간
                    // 4요소를 동시에 처리해낸다.

                }
                sw.Close();
            }

            await Navigation.PopAsync();
        }



        async void OnDeleteButtonClicked(object sender, EventArgs e) // 삭제버튼
        {
            var note = (Note)BindingContext;
            if (File.Exists(note.Filename))
            {
                File.Delete(note.Filename);
            }
            await Navigation.PopAsync();
        }
    }
}
