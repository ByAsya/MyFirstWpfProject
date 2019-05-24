use OOP_Project
drop table Users

create table Tasks
(
	nameTask int identity(1,1) constraint nameTask_PK primary key(nameTask),
	textTask nvarchar(max)
)

create table Topics
(
	nameTopic nvarchar(20) constraint nameT_PK primary key(nameTopic),
	topicText nvarchar(max) default 'На данный момент тема недоступна',
	exampleText nvarchar(max),
	taskCount int
)

create table Users
(
	mail nvarchar(20) constraint mail_PK primary key(mail),
	pictureProfile nvarchar(100) default 'D:\ООП\MyProject\MyProject\pictures\default_user_icon.jpg',
	nameU nvarchar(20) not null,
	passwordU int not null,
	topic nvarchar(20) constraint topic_FK foreign key(topic) references Topics(nameTopic),
	topicCount int default 0
)

