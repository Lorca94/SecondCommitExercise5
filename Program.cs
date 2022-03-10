// start by creating a new SparkPost transmission
using SparkPost;

try
{
    var transmission = new SparkPost.Transmission();
    transmission.Content.From.Email = "lorcanavarrov@gmail.com";
    transmission.Content.Subject = "Hello from SparkPost!";
    transmission.Content.Text = "This is a test email.";
    // add recipients who will receive your email
    var recipient = new Recipient
    {
        Address = new Address { Email = "lorcanavarrov@gmail.com" }
    };
    transmission.Recipients.Add(recipient);
    // create a new API client using your API key
    var client = new Client("1d9c594e68379399c448fc0857a6cd82a60fb828");
    // if you do not understand async/await, use the sync sending mode:
    client.CustomSettings.SendingMode = SendingModes.Sync;
    var response = client.Transmissions.Send(transmission);
} catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}