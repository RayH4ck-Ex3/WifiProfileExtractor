# 𝗪𝗜𝗙𝗜 𝗣𝗥𝗢𝗙𝗜𝗟𝗘 𝗩𝗜𝗘𝗪𝗘𝗥

A simple C# console tool that displays all saved Wi-Fi profiles on your device along with their passwords (if available). The tool also allows you to save the results to a CSV file.

---

## ✨ 𝐅𝐄𝐀𝐓𝐔𝐑𝐄𝐒

- Retrieves all saved Wi-Fi profiles using the `netsh` command.
- Extracts passwords (if stored) for each profile.
- Uses Regex to parse command-line output.
- Saves results to a CSV file.
- Great for learning how to interact with system commands in C#.

---

> 🧑‍🎓 *This tool is beginner-friendly and was built as part of my early learning journey with C#.*  
> *If you're just starting out, this is a great project to understand how C# can interact with system commands.*

---

## ⚙️ 𝐇𝐎𝐖 𝐓𝐎 𝐑𝐔𝐍

1. Open the project in Visual Studio or VS Code.
2. Make sure you have permission to run `netsh` commands.
3. Run the program — it will display all Wi-Fi profiles and their stored passwords (if found), and it will save the results to a `wifi_profiles.csv` file.

---

## 🖥️ 𝐒𝐀𝐌𝐏𝐋𝐄 𝐎𝐔𝐓𝐏𝐔𝐓

Extracting the saved Wifi network on the device: 

--------------------
Network:   Free_Wifi
Password:  password123
--------------------

Result have been saved to wifi_profiles.csv
Finished, press Enter to exit...

---

## 📝 𝐒𝐀𝐌𝐏𝐋𝐄 𝐂𝐒𝐕 𝐎𝐔𝐓𝐏𝐔𝐓

After running the tool, the results will be saved in a file called `wifi_profiles.csv` with the following format:

Free_Wifi, password123


## 👨‍💻 𝐀𝐔𝐓𝐇𝐎𝐑

A beginner developer exploring the world of C#.  
This project was built with curiosity, persistence, and a little help from AI. 😄

---

## 📌 𝐍𝐎𝐓𝐄𝐒

- Passwords are only available if they were stored on the system.
- This works on **Windows only** (since it relies on `netsh`).
- The results will be saved in a file called `wifi_profiles.csv` in the same directory as the program.

---

## 📈 𝐅𝐔𝐓𝐔𝐑𝐄 𝐈𝐌𝐏𝐑𝐎𝐕𝐄𝐌𝐄𝐍𝐓𝐒 *(optional)*

- Add a GUI using WinForms or WPF.
- Export results to additional formats like JSON or Excel.
- Add error handling for missing permissions or unsupported profiles.
- Implement a feature to delete saved Wi-Fi profiles.


