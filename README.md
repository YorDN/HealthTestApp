# Izentia
## 1️⃣ Overview
***Izentia*** is a *digital hub* for storing both phisical and psychological tests. It guides the user and helps him measure his general health. The tests are easy to do through the Web and don't require any *external hardware* ⛔.

## 2️⃣ Authors
    1. Yordan Yordanov - Chief Frontend and Backend / Team Lead
    2. Lyubomir Kostadinov - Backend
    3. Martin Mitev - Research and Marketing
    4. Aleksandra Georgieva - Consultant

## 3️⃣ Documentation
### Purpose 
The purpose of Izentia is to be an easy way for a person to check his well-being 🍃, whilst offering seamless experience for both users and administration 🙍‍♂️. 
### Technology
Izentia relies on the **Blazor Framework** by Microsoft. It uses ***Razor pages*** and ***C#*** to make and connect the Frontend and Backend respectably. \
It uses a Data base for storing the data of the users. **The DB uses *code-first* approach with the SQL Server and Entity Framework Core.**\
Izentia is on .NET 8 version and will be updated in the future. \
Authentication and Authoriasation are done via the **ASP.NET Core Identity**

### Features
- **Test Library** (containing physical and psychological /mental/ tests) 📚
- **Dashboard** for quick health check ❤️‍🩹
- **Feedback panel 🛠️**
- **History of the tests** taken by the user ⏳
- **Profile Manager** 🧑
## 4️⃣ Installation
Izentia doesn't require Installation - if you wish to visit the website you can do so at 
### Prerequisites
- .NET 8 SDK
- SQL Server
- Blazor environment
### Steps

To install (clone) the repository you have to use the GUI of Github or write the following command: 
``` bash
 git clone  https://github.com/YorDN/Izentia.git
```
Upon cloning the project you have to put your connection string in the secrets.json (you can do so in Visual Studio). \
After doing so you have to *migrate* the database into SQL Server. Entity Framework and Entity Framework Tools are preinstalled in the project so you don't have to intall them (but if you do please see the official Microsoft documentation for installation). For input the following command:
```bash
 Add-Migration {Name of the migration}
```
When done migrating update the database:
```bash
 Update-Database
```
## 5️⃣ Contribution
We are open to improvements and we will be happy if you have any ideas on improving the platform as a whole. You can contribute in several different ways: 
- Through the website feedback section, where you can give your feedback for the website and improvements you wish to see happen. After that our team will contact you as fast as possible. 
- Through creating a pull request on the git repo. One of our team members will review your requiest and will decide which action is best for the platform.
- Through direct feedback in our social media platforms. Please note that the responce time is slower if you prefer this option and with lower priority compared to the other methods. There will be community polls and community QNA, which will be with high priority. You will be alerted for them in both social media and in the website.
*Plesase take contribution seriously. Unserious requiest will not be completed and the request/s will be deleted.*
## 6️⃣ Usage
To use Izentia, first you need to make a profile. To do so please follow the provided on page instructions and regulations. \
Upon creating a prfoile you will be granted access to the rest of the website. You will be transfered to the Home (Dashboard) page where you will be displayed your health status, last taken tests reccomendations and a daily feedback on your mood (which resets daily). \
To view all test (or search a specific one) you have to go to the ***All Tests*** section. \
To manage your profile you have to go to the profile section, where you can update your credentials (like email, phone number, etc.). Please refer to the ***Security section*** for information about how your data is used.\
*For individual tests, please follow the provided instructions and regulations.*

## 7️⃣ Data and Security
All data within the Izentia website stays within the Izentia website. We store your data only for the perpose of providing you with correct test results. We DO NOT sell your data to any third-party organisation and we do not use your data when not calculating tests. The data is strictly secured and not everyone has access to it. Even if you are a contributor you do not have access to the content of the database, only to the general table layout and structure for development perposes. Please refer to the more indepth Data and Security section in the website.
