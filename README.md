# short-story
一个通过生成短文来学英语的软件
## 使用方法
win+r，输入cmd，输入cd /C/XXX/story，路径进入文件夹后输入npm start启动程序
![image](https://github.com/user-attachments/assets/79a8de33-79d8-4f88-bff6-2942092ca84c)


## 主要功能

### 1. 生成短文

- 点击"生成短文"按钮，自动生成英语短文（需要3-5s的时间）
- 可在设置中调整文本长度（50-1000字）（不够精确）
- 支持10个难度等级的文本生成（难度分级有些问题，最难的也不是很难）

### 2. 单词学习

- **主页面**：

  - 单击：选中单词
  - 悬停高亮
  - 右键点击：显示翻译和功能菜单

- **生词本**：

  - 点击单词显示中文翻译
  - 🔊 按钮可播放单词发音
  - 支持删除不需要的单词
  - 可按掌握状态筛选显示（全部/已掌握/未掌握）

### 3. 设置选项

#### 生成设置

- 文本长度：调整生成文本的字数
- 文本难度：滑动选择1-10级难度
- 包含生词：可选择在新文本中是否包含生词本中的单词

#### 生词本设置

- 自动显示翻译：开启后生词本直接显示单词翻译，关闭后需点击单词才显示

#### 4.API设置

- 支持以下AI模型：（我只用了deepseek的api可以正常使用，claude和Gemini不知道能否正常使用）
  - Claude
  - Gemini
  - Deepseek
- 在设置中配置对应的API密钥

## 5.注意事项

1. 首次使用需要在设置中配置API密钥
2. 建议保持网络连接以确保翻译和发音功能正常使用
3. 若首次生成短文失败建议关闭软件重新启动


叠甲：由于我毫无经验，只能一直提出要求让cursor增加功能，报错了也让它自己改，所以这东西注定是一坨屎山代码，恳请见谅
