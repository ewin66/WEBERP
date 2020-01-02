

--�ͻ���
create table base_customer
(
	id uniqueidentifier primary key,
	no nvarchar(50) not null default(''),--�ͻ����
	jc_name nvarchar(200) not null default(''),--�ͻ����
	name nvarchar(200) not null default(''),--�ͻ�����
	contacts nvarchar(100) not null default(''),--�ͻ���ϵ��
	contacts_phone nvarchar(100) not null default(''),--�ͻ���ϵ�˵绰
	email nvarchar(100),--����
	grade uniqueidentifier,--�ͻ��ȼ�
	address nvarchar(200) not null default(''),--�ͻ���ַ
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--��Ӧ�̱�
create table base_supplier
(
	id uniqueidentifier primary key,
	no nvarchar(50) not null default(''),--��Ӧ�̱��
	jc_name nvarchar(200) not null default(''),--��Ӧ�̼��
	name nvarchar(200) not null default(''),--��Ӧ������
	contacts nvarchar(100) not null default(''),--��Ӧ����ϵ��
	contacts_phone nvarchar(100) not null default(''),--��Ӧ����ϵ�˵绰
	email nvarchar(100),--����
	grade uniqueidentifier,--��Ӧ�̵ȼ�
	address nvarchar(200) not null default(''),--��Ӧ�̵�ַ
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--�������ݱ�
create table base_data
(
	id uniqueidentifier primary key not null,--����
	name nvarchar(100) not null default(''),---����
	type int not null default(0),--����
	remark nvarchar(300),--��ע˵��
	isenable bit not null default(0),--�Ƿ����
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)

--��Ʒ��
create table base_product
(
	id uniqueidentifier primary key,
	no nvarchar(50) not null default(''),--��Ʒ���
	name nvarchar(200) not null default(''),--��Ʒ����
	type uniqueidentifier,--��Ʒ����1 ��Ʒ,2���Ʒ
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
	type uniqueidentifier,--��������
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
	type uniqueidentifier,--��Ʒ���� 1,������,2,��������
	unit varchar(50) not null default(''),--��λ
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(1000),--����Ҫ��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--���ϱ�
create table base_material
(
	id uniqueidentifier primary key,
	no nvarchar(50) not null default(''),--���ϱ��
	name nvarchar(50) not null default(''),--��������
	type uniqueidentifier not null,--���Ϸ���
	price decimal(10,4) not null default(0),--�ɹ�����
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)

--�ֿ�
create table base_warehouse
(
	id uniqueidentifier primary key not null,--����
	no nvarchar(200) not null default(''),--����� ǰ׺KQ
	name nvarchar(400) not null default(''),--��������
	warehouse_id uniqueidentifier not null,--�����ֿ�
	disabled bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)

--����
create table base_area
(
	id uniqueidentifier primary key not null,--����
	no nvarchar(200) not null default(''),--����� ǰ׺KQ
	name nvarchar(400) not null default(''),--��������
	warehouse_id uniqueidentifier not null,--�����ֿ�
	disabled bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)

--����
create table base_location
(
	id uniqueidentifier primary key not null,--����
	no nvarchar(200) not null default(''),--
	name nvarchar(400) not null default(''),--��������
	warehouse_id uniqueidentifier not null,--�����ֿ�
	area_id uniqueidentifier not null,--��������
	disabled bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)