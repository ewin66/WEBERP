

--�ͻ���
create table base_customer
(
	id int identity(1,1) primary key,
	no nvarchar(50) not null default(''),--�ͻ����
	jc_name nvarchar(200) not null default(''),--�ͻ����
	name nvarchar(200) not null default(''),--�ͻ�����
	contacts nvarchar(100) not null default(''),--�ͻ���ϵ��
	contacts_phone nvarchar(100) not null default(''),--�ͻ���ϵ�˵绰
	email nvarchar(100),--����
	grade int,--�ͻ��ȼ�
	address nvarchar(200) not null default(''),--�ͻ���ַ
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--��Ӧ�̱�
create table base_supplier
(
	id int identity(1,1) primary key,
	no nvarchar(50) not null default(''),--��Ӧ�̱��
	jc_name nvarchar(200) not null default(''),--��Ӧ�̼��
	name nvarchar(200) not null default(''),--��Ӧ������
	contacts nvarchar(100) not null default(''),--��Ӧ����ϵ��
	contacts_phone nvarchar(100) not null default(''),--��Ӧ����ϵ�˵绰
	email nvarchar(100),--����
	grade int,--��Ӧ�̵ȼ�
	address nvarchar(200) not null default(''),--��Ӧ�̵�ַ
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--�������ݱ�
create table base_data
(
	id int identity(1,1) primary key not null,--����
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
	id int identity(1,1) primary key,
	no nvarchar(50) not null default(''),--��Ʒ���
	name nvarchar(200) not null default(''),--��Ʒ����
	type int,--��Ʒ����1 ��Ʒ,2���Ʒ
	guige nvarchar(200),--���
	unit int not null,--��λ
	price decimal(10,4) not null default(0),--��Ʒ����
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--������Ϣ��
create table base_parts
(
	id int identity(1,1) primary key not null,--id
	no nvarchar(50) not null default(''),--�������
	name varchar(50) not null default(''),--����name
	type int,--��������
	unit varchar(50) not null default(''),--��λ
	guige nvarchar(200),--���
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(500),--��ע
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)

--�������ձ�
create table base_technology
(
	id int identity(1,1) primary key not null,--id
	parts_id int not null,--����id
	name varchar(50) not null default(''),--��������
	orderby int not null,
	remark nvarchar(max),--����Ҫ��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--����
create table base_process
(
	id int identity(1,1) primary key not null,--id
	no varchar(50) not null default(''),--������
	name varchar(50) not null default(''),--��������
	type int,--��Ʒ���� 1,������,2,��������
	guige nvarchar(200),--���
	unit varchar(50) not null default(''),--��λ
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(1000),--����Ҫ��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--���ϱ�
create table base_material
(
	id int identity(1,1) primary key,
	no nvarchar(50) not null default(''),--���ϱ��
	name nvarchar(50) not null default(''),--��������
	type int not null,--���Ϸ���
	price decimal(10,4) not null default(0),--�ɹ�����
	guige nvarchar(200),--���
	isenable bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)

--�ֿ�
create table base_warehouse
(
	id int identity(1,1) primary key not null,--����
	no nvarchar(200) not null default(''),--����� ǰ׺KQ
	name nvarchar(400) not null default(''),--��������
	warehouse_id int not null,--�����ֿ�
	disabled bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)

--����
create table base_area
(
	id int identity(1,1) primary key not null,--����
	no nvarchar(200) not null default(''),--����� ǰ׺KQ
	name nvarchar(400) not null default(''),--��������
	warehouse_id int not null,--�����ֿ�
	disabled bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)

--����
create table base_location
(
	id int identity(1,1) primary key not null,--����
	no nvarchar(200) not null default(''),--
	name nvarchar(400) not null default(''),--��������
	warehouse_id int not null,--�����ֿ�
	area_id int not null,--��������
	disabled bit not null default(0),--�Ƿ����
	remark nvarchar(300),--��ע˵��
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--����û�
)


--ʩ������
create table erp_construction
(
	id int identity(1,1) not null,--����
	no nvarchar(100) not null default('') primary key,--TO00001
	product_no nvarchar(100) not null,--��Ʒ���
	product_name nvarchar(100) not null,--��Ʒ����
	customer_no nvarchar(100) not null,--�ͻ����
	customer_name nvarchar(100) not null,--�ͻ�����
	--type int not null,--ʩ��������1,�Բ�,2�ⷢ
	number int not null,--����
	practical_number int,--ʵ����������
	loss_number int,--�������
	guige nvarchar(100) not null,--���
	zhuangdinfa nvarchar(100) not null,--װ����
	baozhuangfa nvarchar(100) not null,--��װ��
	address nvarchar(200) not null,--�ջ���ַ
	delivery_date date not null,--��������
	source_no nvarchar(100),--Դ���ݱ��
	state int not null,--״̬ 0��ȷ�� --1�ƻ���,2������,3�����
	affirm_time datetime,--ȷ��ʱ��
	affirm_username nvarchar(40),--ȷ���û�
	finish_time datetime,--���ʱ��
	finish_username nvarchar(40),--����û�
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--�����û�
)

--ʩ����������
create table erp_parts
(
	id int identity(1,1) not null,--����
	con_no nvarchar(200) not null,--ʩ����ID
	parts_no nvarchar(50) not null,--�������
	parts_name nvarchar(200) not null,--��������
	number int not null,--��������
	state int not null,--״̬ 0��ȷ�� --1������,2������,3�����
	remarrk nvarchar(max),--��ע
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--�����û�
)

--�������������
create table erp_process
(
	id int identity(1,1) not null,--����
	con_no nvarchar(200) not null,--ʩ�������
	erp_parts_id int not null,--��������
	process_no nvarchar(50) not null,--������
	process_name nvarchar(100) not null,--�������� 
	sort int not null,--�����
	number int not null,--�ƻ���������
	practical_number int,--����������
	loss_number int,--�������
	is_waifa bit not null default(0),--�Ƿ��ⷢ
	unit nvarchar(20) not null,--��λ
	knife_no nvarchar(100) not null,--����
	remarrk nvarchar(max),--����Ҫ��
	state int not null,--״̬ 0��ȷ�� --1������,2������,3�����
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--�����û�
)

--�������ϱ�
create table erp_material
(
	id int identity(1,1) not null,--����
	con_no nvarchar(200) not null,--ʩ�������
	erp_parts_id int not null,--��������
	material_no nvarchar(50) not null,--���ϱ��
	material_name nvarchar(100) not null,--�������
	is_waifadailiao bit not null default(0),--�Ƿ����ⷢ����
	number int,--��������
	unit nvarchar(20) not null,--��λ
	remarrk nvarchar(max),--��ע
	create_time datetime not null default(getdate()),--����ʱ��
	create_username nvarchar(40) not null,--�����û�
)


--�ⷢ��