using Application;

namespace UserInterface
{
    public class UI
    {
        private MyApplication1 m_application1 { get; set; }
        private MyApplication2 m_application2 { get; set; }


        public UI()
        {
            m_application1 = new MyApplication1();
            m_application2 = new MyApplication2();
        }

        public void StartGUILoop()
        {
            m_application1.DoWork();

            m_application2.DoWork();


            m_application1.Dispose();
            m_application2.Dispose();
        }

    }
}
