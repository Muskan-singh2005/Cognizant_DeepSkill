using Confluent.Kafka;

namespace KafkaChatClient
{
    public partial class Form1 : Form
    {
        private readonly string topic = "chat";

        public Form1()
        {
            InitializeComponent();

             StartConsumer();  

            btnSend.Click += btnSend_Click;
        }
        private async void btnSend_Click(object? sender, EventArgs e)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            await producer.ProduceAsync(topic,
                new Message<Null, string>
                {
                    Value = txtMessage.Text
                });

            txtMessage.Clear();
        }

        private void StartConsumer()
        {
            Task.Run(() =>
            {
                var config = new ConsumerConfig
                {
                    BootstrapServers = "localhost:9092",
                    GroupId = Guid.NewGuid().ToString(),
                    AutoOffsetReset = AutoOffsetReset.Earliest
                };

                using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();

                consumer.Subscribe(topic);

                while (true)
                {
                    var result = consumer.Consume();

                    Invoke(() =>
                    {
                        rtbChat.AppendText(result.Message.Value + Environment.NewLine);
                    });
                }
            });
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}