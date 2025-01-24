功能要求：设计一个学习英语的win应用，主要内容调用ai的api生成。应用主页面的主体为对话框形式，ui有“生成短文”，“生词”，“设置”三个按钮，其中点击生成短文则可以在对话框生成相应要求的英语短文。对短文中的单词，词组或者句子可以进行操作，shift+左键勾选，左键是显示勾选内容的对应翻译，右键是加入生词本。点击生词可以进入生词本的页面，其中只显示加入生词，左键点一下可以显示对应的翻译，在每个生词前加入圆形按钮，点击圆形按钮即可标熟生词，对应生词画上删除线但是不要从生词本抹去，以后仍然可以点击显示翻译。设置按钮，有“生成设置”“外观设置”“api设置”的子选项，”生成设置“设置生成短文的长度，以及生成短文是否加入生词本里的生词，，外观设置可以设置对话框的背景图片，api设置可以设置使用什么样的模型，以及对应的api以供调用，支持chatgpt，gemini，claude，deepseek的api调用
外观要求：整体以白色为主，勾选后的内容黄色高亮，设计要简洁，对话框为圆角矩形
设计要求：
目标：
设计一套使用原生 JavaScript 开发的代码结构，使代码便于维护。要求每个功能板块分离性强，独立运作，在单独增加或修改某个板块功能时，不会对其他板块产生影响，且为对应代码添加注释。

要求：

模块化设计

每个功能板块封装为独立的模块，文件结构清晰且自包含逻辑、视图和数据。
模块之间通过定义明确的接口进行交互，避免直接访问其他模块的内部实现。
解耦通信

使用事件机制实现模块间通信，避免硬编码模块间的依赖。
例如，一个模块完成任务后触发事件，其他模块监听该事件并作出相应反应。
扩展性和灵活性

新增功能时，只需创建新模块并注册到系统，无需修改现有模块代码。
提供一个统一的模块加载入口，确保模块可以动态加载或移除。
全局依赖最小化

使用配置文件或初始化函数为模块注入必要的依赖，而不是依赖全局变量。
全局作用域中只保留核心管理对象，如事件总线或模块管理器。

扩展要求：

新增模块时：

创建一个新文件（例如 moduleD.js）。
实现 init 和公共方法。
使用 moduleManager.registerModule(moduleD) 将其注册，无需改动其他代码。
删除模块时：

从注册中移除模块，无需改动其他模块的逻辑。