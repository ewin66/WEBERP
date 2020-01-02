
--��Ʒ��
create table base_product
(
	id uniqueidentifier primary key,
	no nvarchar(50) not null default(''),--��Ʒ���
	name nvarchar(200) not null default(''),--��Ʒ����
	type int,--��Ʒ����1 ��Ʒ,2���Ʒ
	unit uniqueidentifier not null,--��λ
	price decimal(10,4) not null default(0),--��Ʒ����
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--������Ϣ��
create table base_parts
(
	id uniqueidentifier primary key not null,--id
	no nvarchar(50) not null default(''),--�������
	name varchar(50) not null default(''),--����name
	type varchar(30) not null default(''),--���� 
	unit varchar(50) not null default(''),--��λ
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(500),--��ע
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)

--����
create table base_process
(
	id uniqueidentifier primary key not null,--id
	no varchar(50) not null default(''),--������
	name varchar(50) not null default(''),--��������
	type int,--��Ʒ���� 1,������,2,��������
	unit varchar(50) not null default(''),--��λ
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(1000),--����Ҫ��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--���ϱ�
create table BaseMaterial
(
	id uniqueidentifier primary key,
	no nvarchar(50) not null default(''),--���ϱ��
	name nvarchar(50) not null default(''),--��������
	type uniqueidentifier not null,--���Ϸ���
	warehouse_id uniqueidentifier not null,--�ֿ�
	purchase_price decimal(10,4) not null default(0),--�ɹ�����
	disabled bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)