# libWindBot
用于 [YGOPro2](https://github.com/Unicorn369/YGOPro2) 动态使用人机程序

## 动态加载 (代码参考)
```
    string GAME_PATH = Environment.CurrentDirectory;
    var assembly = System.Reflection.Assembly.Load("libWindBot.dll");
    Type libWindBot = assembly.GetType("WindBot.WindBot");
    System.Reflection.MethodInfo InitWindBot = libWindBot.GetMethod("InitWindBot", new Type[] { typeof(string), typeof(string), typeof(string) });
    //object obj = Activator.CreateInstance(libWindBot);
    InitWindBot.Invoke(null, new object[] {GAME_PATH, "cards.cdb", "bot.conf"});
```

## 使用 (代码参考)
```
    string command = "Name=悠悠 Deck=MokeyMokey Dialog=mokey.zh-CN Port=7911";
    command = command.Replace("\"", "'");

    System.Reflection.MethodInfo RunWindBot = libWindBot.GetMethod("RunWindBot", new Type[] { typeof(string) });
    RunWindBot.Invoke(null, new object[] {command});
```