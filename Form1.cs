namespace Async
{
    public partial class frmAsync : Form
    {


        public frmAsync()
        {
            InitializeComponent();
        }



        private async Task<string> ExecutarTarefaAssincrona(string nomeTarefa, int tempoEmMilissegundos)
        {
            // Usamos Task.Delay para simular um trabalho que leva tempo,
            // como uma chamada de rede ou acesso a banco de dados.
            // O await garante que a thread atual não seja bloqueada.
            await Task.Delay(tempoEmMilissegundos);

            // Retorna o resultado da tarefa.
            return $"{nomeTarefa} concluída após {tempoEmMilissegundos / 1000} segundos.";
        }



        private async void btnIniciar_ClickAsync(object sender, EventArgs e)
        {
            lbResultados.Items.Clear();
            lblStatus.Text = "Status: Iniciando tarefas...";
            btnIniciar.Enabled = false;

            // Dispara as três tarefas de forma independente.
            var tarefasEmAndamento = new List<Task<string>>
            {
                ExecutarTarefaAssincrona("Tarefa 1", 1000), // 1 seg
                ExecutarTarefaAssincrona("Tarefa 2", 8000), // 8 seg
                ExecutarTarefaAssincrona("Tarefa 3", 4000), // 4 seg
                ExecutarTarefaAssincrona("Tarefa 4", 2000)  // 2 seg
            };

            // Loop para processar as tarefas na ordem em que terminam
            while (tarefasEmAndamento.Count > 0)
            {
                // Espera por qualquer uma das tarefas na lista a ser concluída.
                Task<string> tarefaConcluida = await Task.WhenAny(tarefasEmAndamento);

                // Obtém o resultado da tarefa que terminou.
                string resultado = await tarefaConcluida;

                // Adiciona o resultado ao ListBox imediatamente.
                lbResultados.Items.Add(resultado);

                // Remove a tarefa concluída da lista para não esperá-la novamente.
                tarefasEmAndamento.Remove(tarefaConcluida);
            }

            lblStatus.Text = "Status: Todas as tarefas concluídas!";
            btnIniciar.Enabled = true;
        }    
    }
}
