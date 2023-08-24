var tv = new TV[10];

for(int i = 0; i < 10; i++)
{
    tv[i] = new TV();
    tv[i].GetInfo();
}

for (int i = 0; i < 10; i++)
{
    tv[i].TVOn();
    tv[i].TVOn();
    tv[i].TVOn();
    tv[i].NextChannel();
    tv[i].LastChannel();
    tv[i].NextChannel();
    tv[i].LastChannel();
    tv[i].NextChannel();
    tv[i].NextChannel();
    tv[i].ChangeVolume(15);
    tv[i].ChangePlayingChannel(15);
}
