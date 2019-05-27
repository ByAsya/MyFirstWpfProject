use OOP_Project
drop table Users

create table Tasks
(
	nameTask int identity(1,1) constraint nameTask_PK primary key(nameTask),
	textTask nvarchar(max),
	answers nvarchar(100),
	topicT nvarchar(20) constraint topic�_FK foreign key(topicT) references Topics(nameTopic)
)

drop table Tasks
create table Topics
(
	nameTopic nvarchar(20) constraint nameT_PK primary key(nameTopic),
	topicText nvarchar(max) default '�� ������ ������ ���� ����������',
	exampleText nvarchar(max),
	taskCount int
)

create table Users
(
	mail nvarchar(100) constraint mail_PK primary key(mail),
	pictureProfile nvarchar(100) default 'D:\���\MyProject\MyProject\pictures\default_user_icon.jpg',
	nameU nvarchar(20) not null,
	passwordU nvarchar(10) not null,
	topic nvarchar(20) constraint topic_FK foreign key(topic) references Topics(nameTopic) default '�����',
	points int default 0
)

select * from Topics
delete Topics where topicText='�'

insert Topics values ('�����', '�����','�����',0)

drop table Users
delete Users where mail='sakunnastya28@gmail.com'