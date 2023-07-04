# ECS

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Labels | labels | Custom key/value pairs. | {"application": "foo-bar", "env": "production"} |
| Message | message | Log message optimized for viewing in a log viewer. | Hello World |
| Tags | tags | List of keywords used to tag each event. | ["production", "env2"] |
| Timestamp | @timestamp | Date/time when the event originated. | 2016-05-23T08:05:34.853Z |

## ECS.Agent

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| EphemeralId | agent.ephemeral_id | Ephemeral identifier of this agent. | 8a4f500f |
| Id | agent.id | Unique identifier of this agent. | 8a4f500d |
| Name | agent.name | Custom name of the agent. | foo |
| Type | agent.type | Type of the agent. | filebeat |
| Version | agent.version | Version of the agent. | 6.0.0-rc2 |

### ECS.Agent.Build

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Original | agent.build.original | Extended build information for the agent. | metricbeat version 7.6.0 (amd64), libbeat 7.6.0 [6a23e8f8f30f5001ba344e4e54d8d9cb82cb107c built 2020-02-05 23:10:10 +0000 UTC] |

## ECS.Client

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | client.address | Client network address. |  |
| Bytes | client.bytes | Bytes sent from the client to the server. | 184 |
| Domain | client.domain | The domain name of the client. | foo.example.com |
| Ip | client.ip | IP address of the client. |  |
| Mac | client.mac | MAC address of the client. | 00-00-5E-00-53-23 |
| Packets | client.packets | Packets sent from the client to the server. | 12 |
| Port | client.port | Port of the client. |  |
| RegisteredDomain | client.registered_domain | The highest registered client domain, stripped of the subdomain. | example.com |
| Subdomain | client.subdomain | The subdomain of the domain. | east |
| TopLevelDomain | client.top_level_domain | The effective top level domain (com, org, net, co.uk). | co.uk |

### ECS.Client.As

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Number | client.as.number | Unique number allocated to the autonomous system. | 15169 |

#### ECS.Client.As.Organization

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | client.as.organization.name | Organization name. | Google LLC |
| NameText | client.as.organization.name.text | Organization name. | Google LLC |

### ECS.Client.Geo

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CityName | client.geo.city_name | City name. | Montreal |
| ContinentCode | client.geo.continent_code | Continent code. | NA |
| ContinentName | client.geo.continent_name | Name of the continent. | North America |
| CountryIsoCode | client.geo.country_iso_code | Country ISO code. | CA |
| CountryName | client.geo.country_name | Country name. | Canada |
| Location | client.geo.location | Longitude and latitude. | { "lon": -73.614830, "lat": 45.505918 } |
| Name | client.geo.name | User-defined description of a location. | boston-dc |
| PostalCode | client.geo.postal_code | Postal code. | 94040 |
| RegionIsoCode | client.geo.region_iso_code | Region ISO code. | CA-QC |
| RegionName | client.geo.region_name | Region name. | Quebec |
| Timezone | client.geo.timezone | Time zone. | America/Argentina/Buenos_Aires |

### ECS.Client.Nat

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Ip | client.nat.ip | Client NAT ip address |  |
| Port | client.nat.port | Client NAT port |  |

### ECS.Client.User

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | client.user.domain | Name of the directory the user is a member of. |  |
| Email | client.user.email | User email address. |  |
| FullName | client.user.full_name | User's full name, if available. | Albert Einstein |
| FullNameText | client.user.full_name.text | User's full name, if available. | Albert Einstein |
| Hash | client.user.hash | Unique user hash to correlate information for a user in anonymized form. |  |
| Id | client.user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | client.user.name | Short name or login of the user. | a.einstein |
| NameText | client.user.name.text | Short name or login of the user. | a.einstein |
| Roles | client.user.roles | Array of user roles at the time of the event. | ["kibana_admin", "reporting_user"] |

#### ECS.Client.User.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | client.user.group.domain | Name of the directory the group is a member of. |  |
| Id | client.user.group.id | Unique identifier for the group on the system/platform. |  |
| Name | client.user.group.name | Name of the group. |  |

## ECS.Cloud

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| AvailabilityZone | cloud.availability_zone | Availability zone in which this host, resource, or service is located. | us-east-1c |
| Provider | cloud.provider | Name of the cloud provider. | aws |
| Region | cloud.region | Region in which this host, resource, or service is located. | us-east-1 |

### ECS.Cloud.Account

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | cloud.account.id | The cloud account or organization id. | 666777888999 |
| Name | cloud.account.name | The cloud account name. | elastic-dev |

### ECS.Cloud.Instance

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | cloud.instance.id | Instance ID of the host machine. | i-1234567890abcdef0 |
| Name | cloud.instance.name | Instance name of the host machine. |  |

### ECS.Cloud.Machine

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Type | cloud.machine.type | Machine type of the host machine. | t2.medium |

### ECS.Cloud.Origin

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| AvailabilityZone | cloud.origin.availability_zone | Availability zone in which this host, resource, or service is located. | us-east-1c |
| Provider | cloud.origin.provider | Name of the cloud provider. | aws |
| Region | cloud.origin.region | Region in which this host, resource, or service is located. | us-east-1 |

#### ECS.Cloud.Origin.Account

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | cloud.origin.account.id | The cloud account or organization id. | 666777888999 |
| Name | cloud.origin.account.name | The cloud account name. | elastic-dev |

#### ECS.Cloud.Origin.Instance

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | cloud.origin.instance.id | Instance ID of the host machine. | i-1234567890abcdef0 |
| Name | cloud.origin.instance.name | Instance name of the host machine. |  |

#### ECS.Cloud.Origin.Machine

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Type | cloud.origin.machine.type | Machine type of the host machine. | t2.medium |

#### ECS.Cloud.Origin.Project

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | cloud.origin.project.id | The cloud project id. | my-project |
| Name | cloud.origin.project.name | The cloud project name. | my project |

#### ECS.Cloud.Origin.Service

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | cloud.origin.service.name | The cloud service name. | lambda |

### ECS.Cloud.Project

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | cloud.project.id | The cloud project id. | my-project |
| Name | cloud.project.name | The cloud project name. | my project |

### ECS.Cloud.Service

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | cloud.service.name | The cloud service name. | lambda |

### ECS.Cloud.Target

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| AvailabilityZone | cloud.target.availability_zone | Availability zone in which this host, resource, or service is located. | us-east-1c |
| Provider | cloud.target.provider | Name of the cloud provider. | aws |
| Region | cloud.target.region | Region in which this host, resource, or service is located. | us-east-1 |

#### ECS.Cloud.Target.Account

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | cloud.target.account.id | The cloud account or organization id. | 666777888999 |
| Name | cloud.target.account.name | The cloud account name. | elastic-dev |

#### ECS.Cloud.Target.Instance

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | cloud.target.instance.id | Instance ID of the host machine. | i-1234567890abcdef0 |
| Name | cloud.target.instance.name | Instance name of the host machine. |  |

#### ECS.Cloud.Target.Machine

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Type | cloud.target.machine.type | Machine type of the host machine. | t2.medium |

#### ECS.Cloud.Target.Project

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | cloud.target.project.id | The cloud project id. | my-project |
| Name | cloud.target.project.name | The cloud project name. | my project |

#### ECS.Cloud.Target.Service

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | cloud.target.service.name | The cloud service name. | lambda |

## ECS.Container

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | container.id | Unique container id. |  |
| Labels | container.labels | Image labels. |  |
| Name | container.name | Container name. |  |
| Runtime | container.runtime | Runtime managing this container. | docker |

### ECS.Container.Cpu

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Usage | container.cpu.usage | Percent CPU used, between 0 and 1. |  |

### ECS.Container.Disk

#### ECS.Container.Disk.Read

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | container.disk.read.bytes | The number of bytes read by all disks. |  |

#### ECS.Container.Disk.Write

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | container.disk.write.bytes | The number of bytes written on all disks. |  |

### ECS.Container.Image

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | container.image.name | Name of the image the container was built on. |  |
| Tag | container.image.tag | Container image tags. |  |

#### ECS.Container.Image.Hash

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| All | container.image.hash.all | An array of digests of the image the container was built on. | [sha256:f8fefc80e3273dc756f288a63945820d6476ad64883892c771b5e2ece6bf1b26] |

### ECS.Container.Memory

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Usage | container.memory.usage | Percent memory used, between 0 and 1. |  |

### ECS.Container.Network

#### ECS.Container.Network.Egress

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | container.network.egress.bytes | The number of bytes sent on all network interfaces. |  |

#### ECS.Container.Network.Ingress

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | container.network.ingress.bytes | The number of bytes received on all network interfaces. |  |

## ECS.DataStream

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Dataset | data_stream.dataset | The field can contain anything that makes sense to signify the source of the data. | nginx.access |
| Namespace | data_stream.namespace | A user defined namespace. Namespaces are useful to allow grouping of data. | production |
| Type | data_stream.type | An overarching type for the data stream. | logs |

## ECS.Destination

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | destination.address | Destination network address. |  |
| Bytes | destination.bytes | Bytes sent from the destination to the source. | 184 |
| Domain | destination.domain | The domain name of the destination. | foo.example.com |
| Ip | destination.ip | IP address of the destination. |  |
| Mac | destination.mac | MAC address of the destination. | 00-00-5E-00-53-23 |
| Packets | destination.packets | Packets sent from the destination to the source. | 12 |
| Port | destination.port | Port of the destination. |  |
| RegisteredDomain | destination.registered_domain | The highest registered destination domain, stripped of the subdomain. | example.com |
| Subdomain | destination.subdomain | The subdomain of the domain. | east |
| TopLevelDomain | destination.top_level_domain | The effective top level domain (com, org, net, co.uk). | co.uk |

### ECS.Destination.As

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Number | destination.as.number | Unique number allocated to the autonomous system. | 15169 |

#### ECS.Destination.As.Organization

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | destination.as.organization.name | Organization name. | Google LLC |
| NameText | destination.as.organization.name.text | Organization name. | Google LLC |

### ECS.Destination.Geo

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CityName | destination.geo.city_name | City name. | Montreal |
| ContinentCode | destination.geo.continent_code | Continent code. | NA |
| ContinentName | destination.geo.continent_name | Name of the continent. | North America |
| CountryIsoCode | destination.geo.country_iso_code | Country ISO code. | CA |
| CountryName | destination.geo.country_name | Country name. | Canada |
| Location | destination.geo.location | Longitude and latitude. | { "lon": -73.614830, "lat": 45.505918 } |
| Name | destination.geo.name | User-defined description of a location. | boston-dc |
| PostalCode | destination.geo.postal_code | Postal code. | 94040 |
| RegionIsoCode | destination.geo.region_iso_code | Region ISO code. | CA-QC |
| RegionName | destination.geo.region_name | Region name. | Quebec |
| Timezone | destination.geo.timezone | Time zone. | America/Argentina/Buenos_Aires |

### ECS.Destination.Nat

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Ip | destination.nat.ip | Destination NAT ip |  |
| Port | destination.nat.port | Destination NAT Port |  |

### ECS.Destination.User

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | destination.user.domain | Name of the directory the user is a member of. |  |
| Email | destination.user.email | User email address. |  |
| FullName | destination.user.full_name | User's full name, if available. | Albert Einstein |
| FullNameText | destination.user.full_name.text | User's full name, if available. | Albert Einstein |
| Hash | destination.user.hash | Unique user hash to correlate information for a user in anonymized form. |  |
| Id | destination.user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | destination.user.name | Short name or login of the user. | a.einstein |
| NameText | destination.user.name.text | Short name or login of the user. | a.einstein |
| Roles | destination.user.roles | Array of user roles at the time of the event. | ["kibana_admin", "reporting_user"] |

#### ECS.Destination.User.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | destination.user.group.domain | Name of the directory the group is a member of. |  |
| Id | destination.user.group.id | Unique identifier for the group on the system/platform. |  |
| Name | destination.user.group.name | Name of the group. |  |

## ECS.Device

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | device.id | The unique identifier of a device. | 00000000-54b3-e7c7-0000-000046bffd97 |
| Manufacturer | device.manufacturer | The vendor name of the device manufacturer. | Samsung |

### ECS.Device.Model

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Identifier | device.model.identifier | The machine readable identifier of the device model. | SM-G920F |
| Name | device.model.name | The human readable marketing name of the device model. | Samsung Galaxy S6 |

## ECS.Dll

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | dll.name | Name of the library. | kernel32.dll |
| Path | dll.path | Full file path of the library. | C:\Windows\System32\kernel32.dll |

### ECS.Dll.CodeSignature

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| DigestAlgorithm | dll.code_signature.digest_algorithm | Hashing algorithm used to sign the process. | sha256 |
| Exists | dll.code_signature.exists | Boolean to capture if a signature is present. | true |
| SigningId | dll.code_signature.signing_id | The identifier used to sign the process. | com.apple.xpc.proxy |
| Status | dll.code_signature.status | Additional information about the certificate status. | ERROR_UNTRUSTED_ROOT |
| SubjectName | dll.code_signature.subject_name | Subject name of the code signer | Microsoft Corporation |
| TeamId | dll.code_signature.team_id | The team identifier used to sign the process. | EQHXZ8M8AV |
| Timestamp | dll.code_signature.timestamp | When the signature was generated and signed. | 2021-01-01T12:10:30Z |
| Trusted | dll.code_signature.trusted | Stores the trust status of the certificate chain. | true |
| Valid | dll.code_signature.valid | Boolean to capture if the digital signature is verified against the binary content. | true |

### ECS.Dll.Hash

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Md5 | dll.hash.md5 | MD5 hash. |  |
| Sha1 | dll.hash.sha1 | SHA1 hash. |  |
| Sha256 | dll.hash.sha256 | SHA256 hash. |  |
| Sha384 | dll.hash.sha384 | SHA384 hash. |  |
| Sha512 | dll.hash.sha512 | SHA512 hash. |  |
| Ssdeep | dll.hash.ssdeep | SSDEEP hash. |  |
| Tlsh | dll.hash.tlsh | TLSH hash. |  |

### ECS.Dll.Pe

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Architecture | dll.pe.architecture | CPU architecture target for the file. | x64 |
| Company | dll.pe.company | Internal company name of the file, provided at compile-time. | Microsoft Corporation |
| Description | dll.pe.description | Internal description of the file, provided at compile-time. | Paint |
| FileVersion | dll.pe.file_version | Process name. | 6.3.9600.17415 |
| GoImportHash | dll.pe.go_import_hash | A hash of the Go language imports in a PE file. | 10bddcb4cee42080f76c88d9ff964491 |
| GoImports | dll.pe.go_imports | List of imported Go language element names and types. |  |
| GoImportsNamesEntropy | dll.pe.go_imports_names_entropy | Shannon entropy calculation from the list of Go imports. |  |
| GoImportsNamesVarEntropy | dll.pe.go_imports_names_var_entropy | Variance for Shannon entropy calculation from the list of Go imports. |  |
| GoStripped | dll.pe.go_stripped | Whether the file is a stripped or obfuscated Go executable. |  |
| Imphash | dll.pe.imphash | A hash of the imports in a PE file. | 0c6803c4e922103c4dca5963aad36ddf |
| ImportHash | dll.pe.import_hash | A hash of the imports in a PE file. | d41d8cd98f00b204e9800998ecf8427e |
| Imports | dll.pe.imports | List of imported element names and types. |  |
| ImportsNamesEntropy | dll.pe.imports_names_entropy | Shannon entropy calculation from the list of imported element names and types. |  |
| ImportsNamesVarEntropy | dll.pe.imports_names_var_entropy | Variance for Shannon entropy calculation from the list of imported element names and types. |  |
| OriginalFileName | dll.pe.original_file_name | Internal name of the file, provided at compile-time. | MSPAINT.EXE |
| Pehash | dll.pe.pehash | A hash of the PE header and data from one or more PE sections. | 73ff189b63cd6be375a7ff25179a38d347651975 |
| Product | dll.pe.product | Internal product name of the file, provided at compile-time. | Microsoft® Windows® Operating System |
| Sections | dll.pe.sections | Section information of the PE file. |  |
| SectionsEntropy | dll.pe.sections.entropy | Shannon entropy calculation from the section. |  |
| SectionsName | dll.pe.sections.name | PE Section List name. |  |
| SectionsPhysicalSize | dll.pe.sections.physical_size | PE Section List physical size. |  |
| SectionsVarEntropy | dll.pe.sections.var_entropy | Variance for Shannon entropy calculation from the section. |  |
| SectionsVirtualSize | dll.pe.sections.virtual_size | PE Section List virtual size. This is always the same as `physical_size`. |  |

## ECS.Dns

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Answers | dns.answers | Array of DNS answers. |  |
| AnswersClass | dns.answers.class | The class of DNS data contained in this resource record. | IN |
| AnswersData | dns.answers.data | The data describing the resource. | 10.10.10.10 |
| AnswersName | dns.answers.name | The domain name to which this resource record pertains. | www.example.com |
| AnswersTtl | dns.answers.ttl | The time interval in seconds that this resource record may be cached before it should be discarded. | 180 |
| AnswersType | dns.answers.type | The type of data contained in this resource record. | CNAME |
| HeaderFlags | dns.header_flags | Array of DNS header flags. | ["RD", "RA"] |
| Id | dns.id | The DNS packet identifier assigned by the program that generated the query. The identifier is copied to the response. | 62111 |
| OpCode | dns.op_code | The DNS operation code that specifies the kind of query in the message. | QUERY |
| ResolvedIp | dns.resolved_ip | Array containing all IPs seen in answers.data | ["10.10.10.10", "10.10.10.11"] |
| ResponseCode | dns.response_code | The DNS response code. | NOERROR |
| Type | dns.type | The type of DNS event captured, query or answer. | answer |

### ECS.Dns.Question

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Class | dns.question.class | The class of records being queried. | IN |
| Name | dns.question.name | The name being queried. | www.example.com |
| RegisteredDomain | dns.question.registered_domain | The highest registered domain, stripped of the subdomain. | example.com |
| Subdomain | dns.question.subdomain | The subdomain of the domain. | www |
| TopLevelDomain | dns.question.top_level_domain | The effective top level domain (com, org, net, co.uk). | co.uk |
| Type | dns.question.type | The type of record being queried. | AAAA |

## ECS.Ecs

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Version | ecs.version | ECS version this event conforms to. | 1.0.0 |

## ECS.Email

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Attachments | email.attachments | List of objects describing the attachments. |  |
| ContentType | email.content_type | MIME type of the email message. | text/plain |
| DeliveryTimestamp | email.delivery_timestamp | Date and time when message was delivered. | 2020-11-10T22:12:34.8196921Z |
| Direction | email.direction | Direction of the message. | inbound |
| LocalId | email.local_id | Unique identifier given by the source. | c26dbea0-80d5-463b-b93c-4e8b708219ce |
| MessageId | email.message_id | Value from the Message-ID header. | 81ce15$8r2j59@mail01.example.com |
| OriginationTimestamp | email.origination_timestamp | Date and time the email was composed. | 2020-11-10T22:12:34.8196921Z |
| Subject | email.subject | The subject of the email message. | Please see this important message. |
| SubjectText | email.subject.text | The subject of the email message. | Please see this important message. |
| XMailer | email.x_mailer | Application that drafted email. | Spambot v2.5 |

### ECS.Email.Bcc

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | email.bcc.address | Email address of BCC recipient | bcc.user1@example.com |

### ECS.Email.Cc

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | email.cc.address | Email address of CC recipient | cc.user1@example.com |

### ECS.Email.From

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | email.from.address | The sender's email address. | sender@example.com |

### ECS.Email.ReplyTo

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | email.reply_to.address | Address replies should be delivered to. | reply.here@example.com |

### ECS.Email.Sender

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | email.sender.address | Address of the message sender. |  |

### ECS.Email.To

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | email.to.address | Email address of recipient | user1@example.com |

## ECS.Error

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Code | error.code | Error code describing the error. |  |
| Id | error.id | Unique identifier for the error. |  |
| Message | error.message | Error message. |  |
| StackTrace | error.stack_trace | The stack trace of this error in plain text. |  |
| StackTraceText | error.stack_trace.text | The stack trace of this error in plain text. |  |
| Type | error.type | The type of the error, for example the class name of the exception. | java.lang.NullPointerException |

## ECS.Event

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Action | event.action | The action captured by the event. | user-password-change |
| AgentIdStatus | event.agent_id_status | Validation status of the event's agent.id field. | verified |
| Category | event.category | Event category. The second categorization field in the hierarchy. | authentication |
| Code | event.code | Identification code for this event. | 4648 |
| Created | event.created | Time when the event was first read by an agent or by your pipeline. | 2016-05-23T08:05:34.857Z |
| Dataset | event.dataset | Name of the dataset. | apache.access |
| Duration | event.duration | Duration of the event in nanoseconds. |  |
| End | event.end | `event.end` contains the date when the event ended or when the activity was last observed. |  |
| Hash | event.hash | Hash (perhaps logstash fingerprint) of raw field to be able to demonstrate log integrity. | 123456789012345678901234567890ABCD |
| Id | event.id | Unique ID to describe the event. | 8a4f500d |
| Ingested | event.ingested | Timestamp when an event arrived in the central data store. | 2016-05-23T08:05:35.101Z |
| Kind | event.kind | The kind of the event. The highest categorization field in the hierarchy. | alert |
| Module | event.module | Name of the module this data is coming from. | apache |
| Original | event.original | Raw text message of entire event. | Sep 19 08:26:10 host CEF:0&#124;Security&#124; threatmanager&#124;1.0&#124;100&#124; worm successfully stopped&#124;10&#124;src=10.0.0.1 dst=2.1.2.2spt=1232 |
| Outcome | event.outcome | The outcome of the event. The lowest level categorization field in the hierarchy. | success |
| Provider | event.provider | Source of the event. | kernel |
| Reason | event.reason | Reason why this event happened, according to the source | Terminated an unexpected process |
| Reference | event.reference | Event reference URL | https://system.example.com/event/#0001234 |
| RiskScore | event.risk_score | Risk score or priority of the event (e.g. security solutions). Use your system's original value here. |  |
| RiskScoreNorm | event.risk_score_norm | Normalized risk score or priority of the event (0-100). |  |
| Sequence | event.sequence | Sequence number of the event. |  |
| Severity | event.severity | Numeric severity of the event. | 7 |
| Start | event.start | `event.start` contains the date when the event started or when the activity was first observed. |  |
| Timezone | event.timezone | Event time zone. |  |
| Type | event.type | Event type. The third categorization field in the hierarchy. |  |
| Url | event.url | Event investigation URL | https://mysystem.example.com/alert/5271dedb-f5b0-4218-87f0-4ac4870a38fe |

## ECS.Faas

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Coldstart | faas.coldstart | Boolean value indicating a cold start of a function. |  |
| Execution | faas.execution | The execution ID of the current function execution. | af9d5aa4-a685-4c5f-a22b-444f80b3cc28 |
| Id | faas.id | The unique identifier of a serverless function. | arn:aws:lambda:us-west-2:123456789012:function:my-function |
| Name | faas.name | The name of a serverless function. | my-function |
| Trigger | faas.trigger | Details about the function trigger. |  |
| TriggerRequestId | faas.trigger.request_id | The ID of the trigger request , message, event, etc. | 123456789 |
| TriggerType | faas.trigger.type | The trigger for the function execution. | http |
| Version | faas.version | The version of a serverless function. | 123 |

## ECS.File

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Accessed | file.accessed | Last time the file was accessed. |  |
| Attributes | file.attributes | Array of file attributes. | ["readonly", "system"] |
| Created | file.created | File creation time. |  |
| Ctime | file.ctime | Last time the file attributes or metadata changed. |  |
| Device | file.device | Device that is the source of the file. | sda |
| Directory | file.directory | Directory where the file is located. | /home/alice |
| DriveLetter | file.drive_letter | Drive letter where the file is located. | C |
| Extension | file.extension | File extension, excluding the leading dot. | png |
| ForkName | file.fork_name | A fork is additional data associated with a filesystem object. | Zone.Identifer |
| Gid | file.gid | Primary group ID (GID) of the file. | 1001 |
| Group | file.group | Primary group name of the file. | alice |
| Inode | file.inode | Inode representing the file in the filesystem. | 256383 |
| MimeType | file.mime_type | Media type of file, document, or arrangement of bytes. |  |
| Mode | file.mode | Mode of the file in octal representation. | 0640 |
| Mtime | file.mtime | Last time the file content was modified. |  |
| Name | file.name | Name of the file including the extension, without the directory. | example.png |
| Owner | file.owner | File owner's username. | alice |
| Path | file.path | Full path to the file, including the file name. | /home/alice/example.png |
| PathText | file.path.text | Full path to the file, including the file name. | /home/alice/example.png |
| Size | file.size | File size in bytes. | 16384 |
| TargetPath | file.target_path | Target path for symlinks. |  |
| TargetPathText | file.target_path.text | Target path for symlinks. |  |
| Type | file.type | File type (file, dir, or symlink). | file |
| Uid | file.uid | The user ID (UID) or security identifier (SID) of the file owner. | 1001 |

### ECS.File.CodeSignature

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| DigestAlgorithm | file.code_signature.digest_algorithm | Hashing algorithm used to sign the process. | sha256 |
| Exists | file.code_signature.exists | Boolean to capture if a signature is present. | true |
| SigningId | file.code_signature.signing_id | The identifier used to sign the process. | com.apple.xpc.proxy |
| Status | file.code_signature.status | Additional information about the certificate status. | ERROR_UNTRUSTED_ROOT |
| SubjectName | file.code_signature.subject_name | Subject name of the code signer | Microsoft Corporation |
| TeamId | file.code_signature.team_id | The team identifier used to sign the process. | EQHXZ8M8AV |
| Timestamp | file.code_signature.timestamp | When the signature was generated and signed. | 2021-01-01T12:10:30Z |
| Trusted | file.code_signature.trusted | Stores the trust status of the certificate chain. | true |
| Valid | file.code_signature.valid | Boolean to capture if the digital signature is verified against the binary content. | true |

### ECS.File.Elf

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Architecture | file.elf.architecture | Machine architecture of the ELF file. | x86-64 |
| ByteOrder | file.elf.byte_order | Byte sequence of ELF file. | Little Endian |
| CpuType | file.elf.cpu_type | CPU type of the ELF file. | Intel |
| CreationDate | file.elf.creation_date | Build or compile date. |  |
| Exports | file.elf.exports | List of exported element names and types. |  |
| GoImportHash | file.elf.go_import_hash | A hash of the Go language imports in an ELF file. | 10bddcb4cee42080f76c88d9ff964491 |
| GoImports | file.elf.go_imports | List of imported Go language element names and types. |  |
| GoImportsNamesEntropy | file.elf.go_imports_names_entropy | Shannon entropy calculation from the list of Go imports. |  |
| GoImportsNamesVarEntropy | file.elf.go_imports_names_var_entropy | Variance for Shannon entropy calculation from the list of Go imports. |  |
| GoStripped | file.elf.go_stripped | Whether the file is a stripped or obfuscated Go executable. |  |
| ImportHash | file.elf.import_hash | A hash of the imports in an ELF file. | d41d8cd98f00b204e9800998ecf8427e |
| Imports | file.elf.imports | List of imported element names and types. |  |
| ImportsNamesEntropy | file.elf.imports_names_entropy | Shannon entropy calculation from the list of imported element names and types. |  |
| ImportsNamesVarEntropy | file.elf.imports_names_var_entropy | Variance for Shannon entropy calculation from the list of imported element names and types. |  |
| Sections | file.elf.sections | Section information of the ELF file. |  |
| SectionsChi2 | file.elf.sections.chi2 | Chi-square probability distribution of the section. |  |
| SectionsEntropy | file.elf.sections.entropy | Shannon entropy calculation from the section. |  |
| SectionsFlags | file.elf.sections.flags | ELF Section List flags. |  |
| SectionsName | file.elf.sections.name | ELF Section List name. |  |
| SectionsPhysicalOffset | file.elf.sections.physical_offset | ELF Section List offset. |  |
| SectionsPhysicalSize | file.elf.sections.physical_size | ELF Section List physical size. |  |
| SectionsType | file.elf.sections.type | ELF Section List type. |  |
| SectionsVarEntropy | file.elf.sections.var_entropy | Variance for Shannon entropy calculation from the section. |  |
| SectionsVirtualAddress | file.elf.sections.virtual_address | ELF Section List virtual address. |  |
| SectionsVirtualSize | file.elf.sections.virtual_size | ELF Section List virtual size. |  |
| Segments | file.elf.segments | ELF object segment list. |  |
| SegmentsSections | file.elf.segments.sections | ELF object segment sections. |  |
| SegmentsType | file.elf.segments.type | ELF object segment type. |  |
| SharedLibraries | file.elf.shared_libraries | List of shared libraries used by this ELF object. |  |
| Telfhash | file.elf.telfhash | telfhash hash for ELF file. |  |

#### ECS.File.Elf.Header

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| AbiVersion | file.elf.header.abi_version | Version of the ELF Application Binary Interface (ABI). |  |
| Class | file.elf.header.class | Header class of the ELF file. |  |
| Data | file.elf.header.data | Data table of the ELF header. |  |
| Entrypoint | file.elf.header.entrypoint | Header entrypoint of the ELF file. |  |
| ObjectVersion | file.elf.header.object_version | "0x1" for original ELF files. |  |
| OsAbi | file.elf.header.os_abi | Application Binary Interface (ABI) of the Linux OS. |  |
| Type | file.elf.header.type | Header type of the ELF file. |  |
| Version | file.elf.header.version | Version of the ELF header. |  |

### ECS.File.Hash

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Md5 | file.hash.md5 | MD5 hash. |  |
| Sha1 | file.hash.sha1 | SHA1 hash. |  |
| Sha256 | file.hash.sha256 | SHA256 hash. |  |
| Sha384 | file.hash.sha384 | SHA384 hash. |  |
| Sha512 | file.hash.sha512 | SHA512 hash. |  |
| Ssdeep | file.hash.ssdeep | SSDEEP hash. |  |
| Tlsh | file.hash.tlsh | TLSH hash. |  |

### ECS.File.Macho

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| GoImportHash | file.macho.go_import_hash | A hash of the Go language imports in a Mach-O file. | 10bddcb4cee42080f76c88d9ff964491 |
| GoImports | file.macho.go_imports | List of imported Go language element names and types. |  |
| GoImportsNamesEntropy | file.macho.go_imports_names_entropy | Shannon entropy calculation from the list of Go imports. |  |
| GoImportsNamesVarEntropy | file.macho.go_imports_names_var_entropy | Variance for Shannon entropy calculation from the list of Go imports. |  |
| GoStripped | file.macho.go_stripped | Whether the file is a stripped or obfuscated Go executable. |  |
| ImportHash | file.macho.import_hash | A hash of the imports in a Mach-O file. | d41d8cd98f00b204e9800998ecf8427e |
| Imports | file.macho.imports | List of imported element names and types. |  |
| ImportsNamesEntropy | file.macho.imports_names_entropy | Shannon entropy calculation from the list of imported element names and types. |  |
| ImportsNamesVarEntropy | file.macho.imports_names_var_entropy | Variance for Shannon entropy calculation from the list of imported element names and types. |  |
| Sections | file.macho.sections | Section information of the Mach-O file. |  |
| SectionsEntropy | file.macho.sections.entropy | Shannon entropy calculation from the section. |  |
| SectionsName | file.macho.sections.name | Mach-O Section List name. |  |
| SectionsPhysicalSize | file.macho.sections.physical_size | Mach-O Section List physical size. |  |
| SectionsVarEntropy | file.macho.sections.var_entropy | Variance for Shannon entropy calculation from the section. |  |
| SectionsVirtualSize | file.macho.sections.virtual_size | Mach-O Section List virtual size. This is always the same as `physical_size`. |  |
| Symhash | file.macho.symhash | A hash of the imports in a Mach-O file. | d3ccf195b62a9279c3c19af1080497ec |

### ECS.File.Pe

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Architecture | file.pe.architecture | CPU architecture target for the file. | x64 |
| Company | file.pe.company | Internal company name of the file, provided at compile-time. | Microsoft Corporation |
| Description | file.pe.description | Internal description of the file, provided at compile-time. | Paint |
| FileVersion | file.pe.file_version | Process name. | 6.3.9600.17415 |
| GoImportHash | file.pe.go_import_hash | A hash of the Go language imports in a PE file. | 10bddcb4cee42080f76c88d9ff964491 |
| GoImports | file.pe.go_imports | List of imported Go language element names and types. |  |
| GoImportsNamesEntropy | file.pe.go_imports_names_entropy | Shannon entropy calculation from the list of Go imports. |  |
| GoImportsNamesVarEntropy | file.pe.go_imports_names_var_entropy | Variance for Shannon entropy calculation from the list of Go imports. |  |
| GoStripped | file.pe.go_stripped | Whether the file is a stripped or obfuscated Go executable. |  |
| Imphash | file.pe.imphash | A hash of the imports in a PE file. | 0c6803c4e922103c4dca5963aad36ddf |
| ImportHash | file.pe.import_hash | A hash of the imports in a PE file. | d41d8cd98f00b204e9800998ecf8427e |
| Imports | file.pe.imports | List of imported element names and types. |  |
| ImportsNamesEntropy | file.pe.imports_names_entropy | Shannon entropy calculation from the list of imported element names and types. |  |
| ImportsNamesVarEntropy | file.pe.imports_names_var_entropy | Variance for Shannon entropy calculation from the list of imported element names and types. |  |
| OriginalFileName | file.pe.original_file_name | Internal name of the file, provided at compile-time. | MSPAINT.EXE |
| Pehash | file.pe.pehash | A hash of the PE header and data from one or more PE sections. | 73ff189b63cd6be375a7ff25179a38d347651975 |
| Product | file.pe.product | Internal product name of the file, provided at compile-time. | Microsoft® Windows® Operating System |
| Sections | file.pe.sections | Section information of the PE file. |  |
| SectionsEntropy | file.pe.sections.entropy | Shannon entropy calculation from the section. |  |
| SectionsName | file.pe.sections.name | PE Section List name. |  |
| SectionsPhysicalSize | file.pe.sections.physical_size | PE Section List physical size. |  |
| SectionsVarEntropy | file.pe.sections.var_entropy | Variance for Shannon entropy calculation from the section. |  |
| SectionsVirtualSize | file.pe.sections.virtual_size | PE Section List virtual size. This is always the same as `physical_size`. |  |

### ECS.File.X509

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| AlternativeNames | file.x509.alternative_names | List of subject alternative names (SAN). | *.elastic.co |
| NotAfter | file.x509.not_after | Time at which the certificate is no longer considered valid. | 2020-07-16T03:15:39Z |
| NotBefore | file.x509.not_before | Time at which the certificate is first considered valid. | 2019-08-16T01:40:25Z |
| PublicKeyAlgorithm | file.x509.public_key_algorithm | Algorithm used to generate the public key. | RSA |
| PublicKeyCurve | file.x509.public_key_curve | The curve used by the elliptic curve public key algorithm. This is algorithm specific. | nistp521 |
| PublicKeyExponent | file.x509.public_key_exponent | Exponent used to derive the public key. This is algorithm specific. | 65537 |
| PublicKeySize | file.x509.public_key_size | The size of the public key space in bits. | 2048 |
| SerialNumber | file.x509.serial_number | Unique serial number issued by the certificate authority. | 55FBB9C7DEBF09809D12CCAA |
| SignatureAlgorithm | file.x509.signature_algorithm | Identifier for certificate signature algorithm. | SHA256-RSA |
| VersionNumber | file.x509.version_number | Version of x509 format. | 3 |

#### ECS.File.X509.Issuer

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CommonName | file.x509.issuer.common_name | List of common name (CN) of issuing certificate authority. | Example SHA2 High Assurance Server CA |
| Country | file.x509.issuer.country | List of country \(C) codes | US |
| DistinguishedName | file.x509.issuer.distinguished_name | Distinguished name (DN) of issuing certificate authority. | C=US, O=Example Inc, OU=www.example.com, CN=Example SHA2 High Assurance Server CA |
| Locality | file.x509.issuer.locality | List of locality names (L) | Mountain View |
| Organization | file.x509.issuer.organization | List of organizations (O) of issuing certificate authority. | Example Inc |
| OrganizationalUnit | file.x509.issuer.organizational_unit | List of organizational units (OU) of issuing certificate authority. | www.example.com |
| StateOrProvince | file.x509.issuer.state_or_province | List of state or province names (ST, S, or P) | California |

#### ECS.File.X509.Subject

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CommonName | file.x509.subject.common_name | List of common names (CN) of subject. | shared.global.example.net |
| Country | file.x509.subject.country | List of country \(C) code | US |
| DistinguishedName | file.x509.subject.distinguished_name | Distinguished name (DN) of the certificate subject entity. | C=US, ST=California, L=San Francisco, O=Example, Inc., CN=shared.global.example.net |
| Locality | file.x509.subject.locality | List of locality names (L) | San Francisco |
| Organization | file.x509.subject.organization | List of organizations (O) of subject. | Example, Inc. |
| OrganizationalUnit | file.x509.subject.organizational_unit | List of organizational units (OU) of subject. |  |
| StateOrProvince | file.x509.subject.state_or_province | List of state or province names (ST, S, or P) | California |

## ECS.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | group.domain | Name of the directory the group is a member of. |  |
| Id | group.id | Unique identifier for the group on the system/platform. |  |
| Name | group.name | Name of the group. |  |

## ECS.Host

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Architecture | host.architecture | Operating system architecture. | x86_64 |
| Domain | host.domain | Name of the directory the group is a member of. | CONTOSO |
| Hostname | host.hostname | Hostname of the host. |  |
| Id | host.id | Unique host id. |  |
| Ip | host.ip | Host ip addresses. |  |
| Mac | host.mac | Host MAC addresses. | ["00-00-5E-00-53-23", "00-00-5E-00-53-24"] |
| Name | host.name | Name of the host. |  |
| PidNsIno | host.pid_ns_ino | Pid namespace inode | 256383 |
| Type | host.type | Type of host. |  |
| Uptime | host.uptime | Seconds the host has been up. | 1325 |

### ECS.Host.Boot

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | host.boot.id | Linux boot uuid taken from /proc/sys/kernel/random/boot_id | 88a1f0ed-5ae5-41ee-af6b-41921c311872 |

### ECS.Host.Cpu

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Usage | host.cpu.usage | Percent CPU used, between 0 and 1. |  |

### ECS.Host.Disk

#### ECS.Host.Disk.Read

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | host.disk.read.bytes | The number of bytes read by all disks. |  |

#### ECS.Host.Disk.Write

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | host.disk.write.bytes | The number of bytes written on all disks. |  |

### ECS.Host.Geo

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CityName | host.geo.city_name | City name. | Montreal |
| ContinentCode | host.geo.continent_code | Continent code. | NA |
| ContinentName | host.geo.continent_name | Name of the continent. | North America |
| CountryIsoCode | host.geo.country_iso_code | Country ISO code. | CA |
| CountryName | host.geo.country_name | Country name. | Canada |
| Location | host.geo.location | Longitude and latitude. | { "lon": -73.614830, "lat": 45.505918 } |
| Name | host.geo.name | User-defined description of a location. | boston-dc |
| PostalCode | host.geo.postal_code | Postal code. | 94040 |
| RegionIsoCode | host.geo.region_iso_code | Region ISO code. | CA-QC |
| RegionName | host.geo.region_name | Region name. | Quebec |
| Timezone | host.geo.timezone | Time zone. | America/Argentina/Buenos_Aires |

### ECS.Host.Network

#### ECS.Host.Network.Egress

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | host.network.egress.bytes | The number of bytes sent on all network interfaces. |  |
| Packets | host.network.egress.packets | The number of packets sent on all network interfaces. |  |

#### ECS.Host.Network.Ingress

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | host.network.ingress.bytes | The number of bytes received on all network interfaces. |  |
| Packets | host.network.ingress.packets | The number of packets received on all network interfaces. |  |

### ECS.Host.Os

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Family | host.os.family | OS family (such as redhat, debian, freebsd, windows). | debian |
| Full | host.os.full | Operating system name, including the version or code name. | Mac OS Mojave |
| FullText | host.os.full.text | Operating system name, including the version or code name. | Mac OS Mojave |
| Kernel | host.os.kernel | Operating system kernel version as a raw string. | 4.4.0-112-generic |
| Name | host.os.name | Operating system name, without the version. | Mac OS X |
| NameText | host.os.name.text | Operating system name, without the version. | Mac OS X |
| Platform | host.os.platform | Operating system platform (such centos, ubuntu, windows). | darwin |
| Type | host.os.type | Which commercial OS family (one of: linux, macos, unix, windows, ios or android). | macos |
| Version | host.os.version | Operating system version as a raw string. | 10.14.1 |

### ECS.Host.Risk

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CalculatedLevel | host.risk.calculated_level | A risk classification level calculated by an internal system as part of entity analytics and entity risk scoring. | High |
| CalculatedScore | host.risk.calculated_score | A risk classification score calculated by an internal system as part of entity analytics and entity risk scoring. | 880.73 |
| CalculatedScoreNorm | host.risk.calculated_score_norm | A normalized risk score calculated by an internal system. | 88.73 |
| StaticLevel | host.risk.static_level | A risk classification level obtained from outside the system, such as from some external Threat Intelligence Platform. | High |
| StaticScore | host.risk.static_score | A risk classification score obtained from outside the system, such as from some external Threat Intelligence Platform. | 830.0 |
| StaticScoreNorm | host.risk.static_score_norm | A normalized risk score calculated by an external system. | 83.0 |

## ECS.Http

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Version | http.version | HTTP version. | 1.1 |

### ECS.Http.Request

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | http.request.bytes | Total size in bytes of the request (body and headers). | 1437 |
| Id | http.request.id | HTTP request ID. | 123e4567-e89b-12d3-a456-426614174000 |
| Method | http.request.method | HTTP request method. | POST |
| MimeType | http.request.mime_type | Mime type of the body of the request. | image/gif |
| Referrer | http.request.referrer | Referrer for this HTTP request. | https://blog.example.com/ |

#### ECS.Http.Request.Body

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | http.request.body.bytes | Size in bytes of the request body. | 887 |
| Content | http.request.body.content | The full HTTP request body. | Hello world |
| ContentText | http.request.body.content.text | The full HTTP request body. | Hello world |

### ECS.Http.Response

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | http.response.bytes | Total size in bytes of the response (body and headers). | 1437 |
| MimeType | http.response.mime_type | Mime type of the body of the response. | image/gif |
| StatusCode | http.response.status_code | HTTP response status code. | 404 |

#### ECS.Http.Response.Body

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | http.response.body.bytes | Size in bytes of the response body. | 887 |
| Content | http.response.body.content | The full HTTP response body. | Hello world |
| ContentText | http.response.body.content.text | The full HTTP response body. | Hello world |

## ECS.Log

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Level | log.level | Log level of the log event. | error |
| Logger | log.logger | Name of the logger. | org.elasticsearch.bootstrap.Bootstrap |
| Syslog | log.syslog | Syslog metadata |  |
| SyslogAppname | log.syslog.appname | The device or application that originated the Syslog message. | sshd |
| SyslogHostname | log.syslog.hostname | The host that originated the Syslog message. | example-host |
| SyslogMsgid | log.syslog.msgid | An identifier for the type of Syslog message. | ID47 |
| SyslogPriority | log.syslog.priority | Syslog priority of the event. | 135 |
| SyslogProcid | log.syslog.procid | The process name or ID that originated the Syslog message. | 12345 |
| SyslogStructuredData | log.syslog.structured_data | Structured data expressed in RFC 5424 messages. |  |
| SyslogVersion | log.syslog.version | Syslog protocol version. | 1 |

### ECS.Log.File

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Path | log.file.path | Full path to the log file this event came from. | /var/log/fun-times.log |

### ECS.Log.Origin

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Function | log.origin.function | The function which originated the log event. | init |

#### ECS.Log.Origin.File

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Line | log.origin.file.line | The line number of the file which originated the log event. | 42 |
| Name | log.origin.file.name | The code file which originated the log event. | Bootstrap.java |

## ECS.Network

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Application | network.application | Application level protocol name. | aim |
| Bytes | network.bytes | Total bytes transferred in both directions. | 368 |
| CommunityId | network.community_id | A hash of source and destination IPs and ports. | 1:hO+sN4H+MG5MY/8hIrXPqc4ZQz0= |
| Direction | network.direction | Direction of the network traffic. | inbound |
| ForwardedIp | network.forwarded_ip | Host IP address when the source IP address is the proxy. | 192.1.1.2 |
| IanaNumber | network.iana_number | IANA Protocol Number. | 6 |
| Inner | network.inner | Inner VLAN tag information |  |
| Name | network.name | Name given by operators to sections of their network. | Guest Wifi |
| Packets | network.packets | Total packets transferred in both directions. | 24 |
| Protocol | network.protocol | Application protocol name. | http |
| Transport | network.transport | Protocol Name corresponding to the field `iana_number`. | tcp |
| Type | network.type | In the OSI Model this would be the Network Layer. ipv4, ipv6, ipsec, pim, etc | ipv4 |

### ECS.Network.Vlan

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | network.vlan.id | VLAN ID as reported by the observer. | 10 |
| Name | network.vlan.name | Optional VLAN name as reported by the observer. | outside |

## ECS.Observer

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Egress | observer.egress | Object field for egress information |  |
| EgressZone | observer.egress.zone | Observer Egress zone | Public_Internet |
| Hostname | observer.hostname | Hostname of the observer. |  |
| Ingress | observer.ingress | Object field for ingress information |  |
| IngressZone | observer.ingress.zone | Observer ingress zone | DMZ |
| Ip | observer.ip | IP addresses of the observer. |  |
| Mac | observer.mac | MAC addresses of the observer. | ["00-00-5E-00-53-23", "00-00-5E-00-53-24"] |
| Name | observer.name | Custom name of the observer. | 1_proxySG |
| Product | observer.product | The product name of the observer. | s200 |
| SerialNumber | observer.serial_number | Observer serial number. |  |
| Type | observer.type | The type of the observer the data is coming from. | firewall |
| Vendor | observer.vendor | Vendor name of the observer. | Symantec |
| Version | observer.version | Observer version. |  |

### ECS.Observer.Geo

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CityName | observer.geo.city_name | City name. | Montreal |
| ContinentCode | observer.geo.continent_code | Continent code. | NA |
| ContinentName | observer.geo.continent_name | Name of the continent. | North America |
| CountryIsoCode | observer.geo.country_iso_code | Country ISO code. | CA |
| CountryName | observer.geo.country_name | Country name. | Canada |
| Location | observer.geo.location | Longitude and latitude. | { "lon": -73.614830, "lat": 45.505918 } |
| Name | observer.geo.name | User-defined description of a location. | boston-dc |
| PostalCode | observer.geo.postal_code | Postal code. | 94040 |
| RegionIsoCode | observer.geo.region_iso_code | Region ISO code. | CA-QC |
| RegionName | observer.geo.region_name | Region name. | Quebec |
| Timezone | observer.geo.timezone | Time zone. | America/Argentina/Buenos_Aires |

### ECS.Observer.Os

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Family | observer.os.family | OS family (such as redhat, debian, freebsd, windows). | debian |
| Full | observer.os.full | Operating system name, including the version or code name. | Mac OS Mojave |
| FullText | observer.os.full.text | Operating system name, including the version or code name. | Mac OS Mojave |
| Kernel | observer.os.kernel | Operating system kernel version as a raw string. | 4.4.0-112-generic |
| Name | observer.os.name | Operating system name, without the version. | Mac OS X |
| NameText | observer.os.name.text | Operating system name, without the version. | Mac OS X |
| Platform | observer.os.platform | Operating system platform (such centos, ubuntu, windows). | darwin |
| Type | observer.os.type | Which commercial OS family (one of: linux, macos, unix, windows, ios or android). | macos |
| Version | observer.os.version | Operating system version as a raw string. | 10.14.1 |

## ECS.Orchestrator

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| ApiVersion | orchestrator.api_version | API version being used to carry out the action | v1beta1 |
| Namespace | orchestrator.namespace | Namespace in which the action is taking place. | kube-system |
| Organization | orchestrator.organization | Organization affected by the event (for multi-tenant orchestrator setups). | elastic |
| Type | orchestrator.type | Orchestrator cluster type (e.g. kubernetes, nomad or cloudfoundry). | kubernetes |

### ECS.Orchestrator.Cluster

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | orchestrator.cluster.id | Unique ID of the cluster. |  |
| Name | orchestrator.cluster.name | Name of the cluster. |  |
| Url | orchestrator.cluster.url | URL of the API used to manage the cluster. |  |
| Version | orchestrator.cluster.version | The version of the cluster. |  |

### ECS.Orchestrator.Resource

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Annotation | orchestrator.resource.annotation | The list of annotations added to the resource. | ['key1:value1', 'key2:value2', 'key3:value3'] |
| Id | orchestrator.resource.id | Unique ID of the resource being acted upon. |  |
| Ip | orchestrator.resource.ip | IP address assigned to the resource associated with the event being observed. |  |
| Label | orchestrator.resource.label | The list of labels added to the resource. | ['key1:value1', 'key2:value2', 'key3:value3'] |
| Name | orchestrator.resource.name | Name of the resource being acted upon. | test-pod-cdcws |
| Type | orchestrator.resource.type | Type of resource being acted upon. | service |

#### ECS.Orchestrator.Resource.Parent

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Type | orchestrator.resource.parent.type | Type or kind of the parent resource associated with the event being observed. | DaemonSet |

## ECS.Organization

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | organization.id | Unique identifier for the organization. |  |
| Name | organization.name | Organization name. |  |
| NameText | organization.name.text | Organization name. |  |

## ECS.Package

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Architecture | package.architecture | Package architecture. | x86_64 |
| BuildVersion | package.build_version | Build version information | 36f4f7e89dd61b0988b12ee000b98966867710cd |
| Checksum | package.checksum | Checksum of the installed package for verification. | 68b329da9893e34099c7d8ad5cb9c940 |
| Description | package.description | Description of the package. | Open source programming language to build simple/reliable/efficient software. |
| Installed | package.installed | Time when package was installed. |  |
| InstallScope | package.install_scope | Indicating how the package was installed, e.g. user-local, global. | global |
| License | package.license | Package license | Apache License 2.0 |
| Name | package.name | Package name | go |
| Path | package.path | Path where the package is installed. | /usr/local/Cellar/go/1.12.9/ |
| Reference | package.reference | Package home page or reference URL | https://golang.org |
| Size | package.size | Package size in bytes. | 62231 |
| Type | package.type | Package type | rpm |
| Version | package.version | Package version | 1.12.9 |

## ECS.Process

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Args | process.args | Array of process arguments. | ["/usr/bin/ssh", "-l", "user", "10.0.0.16"] |
| ArgsCount | process.args_count | Length of the process.args array. | 4 |
| CommandLine | process.command_line | Full command line that started the process. | /usr/bin/ssh -l user 10.0.0.16 |
| CommandLineText | process.command_line.text | Full command line that started the process. | /usr/bin/ssh -l user 10.0.0.16 |
| End | process.end | The time the process ended. | 2016-05-23T08:05:34.853Z |
| EntityId | process.entity_id | Unique identifier for the process. | c2c455d9f99375d |
| EnvVars | process.env_vars | Array of environment variable bindings. | ["PATH=/usr/local/bin:/usr/bin", "USER=ubuntu"] |
| Executable | process.executable | Absolute path to the process executable. | /usr/bin/ssh |
| ExecutableText | process.executable.text | Absolute path to the process executable. | /usr/bin/ssh |
| ExitCode | process.exit_code | The exit code of the process. | 137 |
| Interactive | process.interactive | Whether the process is connected to an interactive shell. | True |
| Io | process.io | A chunk of input or output (IO) from a single process. |  |
| IoBytesSkipped | process.io.bytes_skipped | An array of byte offsets and lengths denoting where IO data has been skipped. |  |
| IoMaxBytesPerProcessExceeded | process.io.max_bytes_per_process_exceeded | If true, the process producing the output has exceeded the max_kilobytes_per_process configuration setting. |  |
| IoText | process.io.text | A chunk of output or input sanitized to UTF-8. |  |
| IoTotalBytesCaptured | process.io.total_bytes_captured | The total number of bytes captured in this event. |  |
| IoTotalBytesSkipped | process.io.total_bytes_skipped | The total number of bytes that were not captured due to implementation restrictions such as buffer size limits. |  |
| IoType | process.io.type | The type of object on which the IO action (read or write) was taken. |  |
| Name | process.name | Process name. | ssh |
| NameText | process.name.text | Process name. | ssh |
| Pgid | process.pgid | Deprecated identifier of the group of processes the process belongs to. |  |
| Pid | process.pid | Process id. | 4242 |
| Start | process.start | The time the process started. | 2016-05-23T08:05:34.853Z |
| Title | process.title | Process title. |  |
| TitleText | process.title.text | Process title. |  |
| Tty | process.tty | Information about the controlling TTY device. |  |
| TtyColumns | process.tty.columns | The number of character columns per line. e.g terminal width | 80 |
| TtyRows | process.tty.rows | The number of character rows in the terminal. e.g terminal height | 24 |
| Uptime | process.uptime | Seconds the process has been up. | 1325 |
| WorkingDirectory | process.working_directory | The working directory of the process. | /home/alice |
| WorkingDirectoryText | process.working_directory.text | The working directory of the process. | /home/alice |

### ECS.Process.CodeSignature

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| DigestAlgorithm | process.code_signature.digest_algorithm | Hashing algorithm used to sign the process. | sha256 |
| Exists | process.code_signature.exists | Boolean to capture if a signature is present. | true |
| SigningId | process.code_signature.signing_id | The identifier used to sign the process. | com.apple.xpc.proxy |
| Status | process.code_signature.status | Additional information about the certificate status. | ERROR_UNTRUSTED_ROOT |
| SubjectName | process.code_signature.subject_name | Subject name of the code signer | Microsoft Corporation |
| TeamId | process.code_signature.team_id | The team identifier used to sign the process. | EQHXZ8M8AV |
| Timestamp | process.code_signature.timestamp | When the signature was generated and signed. | 2021-01-01T12:10:30Z |
| Trusted | process.code_signature.trusted | Stores the trust status of the certificate chain. | true |
| Valid | process.code_signature.valid | Boolean to capture if the digital signature is verified against the binary content. | true |

### ECS.Process.Elf

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Architecture | process.elf.architecture | Machine architecture of the ELF file. | x86-64 |
| ByteOrder | process.elf.byte_order | Byte sequence of ELF file. | Little Endian |
| CpuType | process.elf.cpu_type | CPU type of the ELF file. | Intel |
| CreationDate | process.elf.creation_date | Build or compile date. |  |
| Exports | process.elf.exports | List of exported element names and types. |  |
| GoImportHash | process.elf.go_import_hash | A hash of the Go language imports in an ELF file. | 10bddcb4cee42080f76c88d9ff964491 |
| GoImports | process.elf.go_imports | List of imported Go language element names and types. |  |
| GoImportsNamesEntropy | process.elf.go_imports_names_entropy | Shannon entropy calculation from the list of Go imports. |  |
| GoImportsNamesVarEntropy | process.elf.go_imports_names_var_entropy | Variance for Shannon entropy calculation from the list of Go imports. |  |
| GoStripped | process.elf.go_stripped | Whether the file is a stripped or obfuscated Go executable. |  |
| ImportHash | process.elf.import_hash | A hash of the imports in an ELF file. | d41d8cd98f00b204e9800998ecf8427e |
| Imports | process.elf.imports | List of imported element names and types. |  |
| ImportsNamesEntropy | process.elf.imports_names_entropy | Shannon entropy calculation from the list of imported element names and types. |  |
| ImportsNamesVarEntropy | process.elf.imports_names_var_entropy | Variance for Shannon entropy calculation from the list of imported element names and types. |  |
| Sections | process.elf.sections | Section information of the ELF file. |  |
| SectionsChi2 | process.elf.sections.chi2 | Chi-square probability distribution of the section. |  |
| SectionsEntropy | process.elf.sections.entropy | Shannon entropy calculation from the section. |  |
| SectionsFlags | process.elf.sections.flags | ELF Section List flags. |  |
| SectionsName | process.elf.sections.name | ELF Section List name. |  |
| SectionsPhysicalOffset | process.elf.sections.physical_offset | ELF Section List offset. |  |
| SectionsPhysicalSize | process.elf.sections.physical_size | ELF Section List physical size. |  |
| SectionsType | process.elf.sections.type | ELF Section List type. |  |
| SectionsVarEntropy | process.elf.sections.var_entropy | Variance for Shannon entropy calculation from the section. |  |
| SectionsVirtualAddress | process.elf.sections.virtual_address | ELF Section List virtual address. |  |
| SectionsVirtualSize | process.elf.sections.virtual_size | ELF Section List virtual size. |  |
| Segments | process.elf.segments | ELF object segment list. |  |
| SegmentsSections | process.elf.segments.sections | ELF object segment sections. |  |
| SegmentsType | process.elf.segments.type | ELF object segment type. |  |
| SharedLibraries | process.elf.shared_libraries | List of shared libraries used by this ELF object. |  |
| Telfhash | process.elf.telfhash | telfhash hash for ELF file. |  |

#### ECS.Process.Elf.Header

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| AbiVersion | process.elf.header.abi_version | Version of the ELF Application Binary Interface (ABI). |  |
| Class | process.elf.header.class | Header class of the ELF file. |  |
| Data | process.elf.header.data | Data table of the ELF header. |  |
| Entrypoint | process.elf.header.entrypoint | Header entrypoint of the ELF file. |  |
| ObjectVersion | process.elf.header.object_version | "0x1" for original ELF files. |  |
| OsAbi | process.elf.header.os_abi | Application Binary Interface (ABI) of the Linux OS. |  |
| Type | process.elf.header.type | Header type of the ELF file. |  |
| Version | process.elf.header.version | Version of the ELF header. |  |

### ECS.Process.EntryLeader

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Args | process.entry_leader.args | Array of process arguments. | ["/usr/bin/ssh", "-l", "user", "10.0.0.16"] |
| ArgsCount | process.entry_leader.args_count | Length of the process.args array. | 4 |
| CommandLine | process.entry_leader.command_line | Full command line that started the process. | /usr/bin/ssh -l user 10.0.0.16 |
| CommandLineText | process.entry_leader.command_line.text | Full command line that started the process. | /usr/bin/ssh -l user 10.0.0.16 |
| EntityId | process.entry_leader.entity_id | Unique identifier for the process. | c2c455d9f99375d |
| Executable | process.entry_leader.executable | Absolute path to the process executable. | /usr/bin/ssh |
| ExecutableText | process.entry_leader.executable.text | Absolute path to the process executable. | /usr/bin/ssh |
| Interactive | process.entry_leader.interactive | Whether the process is connected to an interactive shell. | True |
| Name | process.entry_leader.name | Process name. | ssh |
| NameText | process.entry_leader.name.text | Process name. | ssh |
| Pid | process.entry_leader.pid | Process id. | 4242 |
| SameAsProcess | process.entry_leader.same_as_process | This boolean is used to identify if a leader process is the same as the top level process. | True |
| Start | process.entry_leader.start | The time the process started. | 2016-05-23T08:05:34.853Z |
| Tty | process.entry_leader.tty | Information about the controlling TTY device. |  |
| WorkingDirectory | process.entry_leader.working_directory | The working directory of the process. | /home/alice |
| WorkingDirectoryText | process.entry_leader.working_directory.text | The working directory of the process. | /home/alice |

#### ECS.Process.EntryLeader.AttestedGroups

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | process.entry_leader.attested_groups.name | Name of the group. |  |

#### ECS.Process.EntryLeader.AttestedUser

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.entry_leader.attested_user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.entry_leader.attested_user.name | Short name or login of the user. | a.einstein |
| NameText | process.entry_leader.attested_user.name.text | Short name or login of the user. | a.einstein |

#### ECS.Process.EntryLeader.EntryMeta

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Type | process.entry_leader.entry_meta.type | The entry type for the entry session leader. |  |

##### ECS.Process.EntryLeader.EntryMeta.Source

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Ip | process.entry_leader.entry_meta.source.ip | IP address of the source. |  |

#### ECS.Process.EntryLeader.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.entry_leader.group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.entry_leader.group.name | Name of the group. |  |

#### ECS.Process.EntryLeader.Parent

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| EntityId | process.entry_leader.parent.entity_id | Unique identifier for the process. | c2c455d9f99375d |
| Pid | process.entry_leader.parent.pid | Process id. | 4242 |
| Start | process.entry_leader.parent.start | The time the process started. | 2016-05-23T08:05:34.853Z |

##### ECS.Process.EntryLeader.Parent.SessionLeader

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| EntityId | process.entry_leader.parent.session_leader.entity_id | Unique identifier for the process. | c2c455d9f99375d |
| Pid | process.entry_leader.parent.session_leader.pid | Process id. | 4242 |
| Start | process.entry_leader.parent.session_leader.start | The time the process started. | 2016-05-23T08:05:34.853Z |

#### ECS.Process.EntryLeader.RealGroup

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.entry_leader.real_group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.entry_leader.real_group.name | Name of the group. |  |

#### ECS.Process.EntryLeader.RealUser

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.entry_leader.real_user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.entry_leader.real_user.name | Short name or login of the user. | a.einstein |
| NameText | process.entry_leader.real_user.name.text | Short name or login of the user. | a.einstein |

#### ECS.Process.EntryLeader.SavedGroup

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.entry_leader.saved_group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.entry_leader.saved_group.name | Name of the group. |  |

#### ECS.Process.EntryLeader.SavedUser

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.entry_leader.saved_user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.entry_leader.saved_user.name | Short name or login of the user. | a.einstein |
| NameText | process.entry_leader.saved_user.name.text | Short name or login of the user. | a.einstein |

#### ECS.Process.EntryLeader.SupplementalGroups

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.entry_leader.supplemental_groups.id | Unique identifier for the group on the system/platform. |  |
| Name | process.entry_leader.supplemental_groups.name | Name of the group. |  |

#### ECS.Process.EntryLeader.User

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.entry_leader.user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.entry_leader.user.name | Short name or login of the user. | a.einstein |
| NameText | process.entry_leader.user.name.text | Short name or login of the user. | a.einstein |

### ECS.Process.GroupLeader

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Args | process.group_leader.args | Array of process arguments. | ["/usr/bin/ssh", "-l", "user", "10.0.0.16"] |
| ArgsCount | process.group_leader.args_count | Length of the process.args array. | 4 |
| CommandLine | process.group_leader.command_line | Full command line that started the process. | /usr/bin/ssh -l user 10.0.0.16 |
| CommandLineText | process.group_leader.command_line.text | Full command line that started the process. | /usr/bin/ssh -l user 10.0.0.16 |
| EntityId | process.group_leader.entity_id | Unique identifier for the process. | c2c455d9f99375d |
| Executable | process.group_leader.executable | Absolute path to the process executable. | /usr/bin/ssh |
| ExecutableText | process.group_leader.executable.text | Absolute path to the process executable. | /usr/bin/ssh |
| Interactive | process.group_leader.interactive | Whether the process is connected to an interactive shell. | True |
| Name | process.group_leader.name | Process name. | ssh |
| NameText | process.group_leader.name.text | Process name. | ssh |
| Pid | process.group_leader.pid | Process id. | 4242 |
| SameAsProcess | process.group_leader.same_as_process | This boolean is used to identify if a leader process is the same as the top level process. | True |
| Start | process.group_leader.start | The time the process started. | 2016-05-23T08:05:34.853Z |
| Tty | process.group_leader.tty | Information about the controlling TTY device. |  |
| WorkingDirectory | process.group_leader.working_directory | The working directory of the process. | /home/alice |
| WorkingDirectoryText | process.group_leader.working_directory.text | The working directory of the process. | /home/alice |

#### ECS.Process.GroupLeader.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.group_leader.group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.group_leader.group.name | Name of the group. |  |

#### ECS.Process.GroupLeader.RealGroup

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.group_leader.real_group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.group_leader.real_group.name | Name of the group. |  |

#### ECS.Process.GroupLeader.RealUser

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.group_leader.real_user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.group_leader.real_user.name | Short name or login of the user. | a.einstein |
| NameText | process.group_leader.real_user.name.text | Short name or login of the user. | a.einstein |

#### ECS.Process.GroupLeader.SavedGroup

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.group_leader.saved_group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.group_leader.saved_group.name | Name of the group. |  |

#### ECS.Process.GroupLeader.SavedUser

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.group_leader.saved_user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.group_leader.saved_user.name | Short name or login of the user. | a.einstein |
| NameText | process.group_leader.saved_user.name.text | Short name or login of the user. | a.einstein |

#### ECS.Process.GroupLeader.SupplementalGroups

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.group_leader.supplemental_groups.id | Unique identifier for the group on the system/platform. |  |
| Name | process.group_leader.supplemental_groups.name | Name of the group. |  |

#### ECS.Process.GroupLeader.User

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.group_leader.user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.group_leader.user.name | Short name or login of the user. | a.einstein |
| NameText | process.group_leader.user.name.text | Short name or login of the user. | a.einstein |

### ECS.Process.Hash

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Md5 | process.hash.md5 | MD5 hash. |  |
| Sha1 | process.hash.sha1 | SHA1 hash. |  |
| Sha256 | process.hash.sha256 | SHA256 hash. |  |
| Sha384 | process.hash.sha384 | SHA384 hash. |  |
| Sha512 | process.hash.sha512 | SHA512 hash. |  |
| Ssdeep | process.hash.ssdeep | SSDEEP hash. |  |
| Tlsh | process.hash.tlsh | TLSH hash. |  |

### ECS.Process.Macho

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| GoImportHash | process.macho.go_import_hash | A hash of the Go language imports in a Mach-O file. | 10bddcb4cee42080f76c88d9ff964491 |
| GoImports | process.macho.go_imports | List of imported Go language element names and types. |  |
| GoImportsNamesEntropy | process.macho.go_imports_names_entropy | Shannon entropy calculation from the list of Go imports. |  |
| GoImportsNamesVarEntropy | process.macho.go_imports_names_var_entropy | Variance for Shannon entropy calculation from the list of Go imports. |  |
| GoStripped | process.macho.go_stripped | Whether the file is a stripped or obfuscated Go executable. |  |
| ImportHash | process.macho.import_hash | A hash of the imports in a Mach-O file. | d41d8cd98f00b204e9800998ecf8427e |
| Imports | process.macho.imports | List of imported element names and types. |  |
| ImportsNamesEntropy | process.macho.imports_names_entropy | Shannon entropy calculation from the list of imported element names and types. |  |
| ImportsNamesVarEntropy | process.macho.imports_names_var_entropy | Variance for Shannon entropy calculation from the list of imported element names and types. |  |
| Sections | process.macho.sections | Section information of the Mach-O file. |  |
| SectionsEntropy | process.macho.sections.entropy | Shannon entropy calculation from the section. |  |
| SectionsName | process.macho.sections.name | Mach-O Section List name. |  |
| SectionsPhysicalSize | process.macho.sections.physical_size | Mach-O Section List physical size. |  |
| SectionsVarEntropy | process.macho.sections.var_entropy | Variance for Shannon entropy calculation from the section. |  |
| SectionsVirtualSize | process.macho.sections.virtual_size | Mach-O Section List virtual size. This is always the same as `physical_size`. |  |
| Symhash | process.macho.symhash | A hash of the imports in a Mach-O file. | d3ccf195b62a9279c3c19af1080497ec |

### ECS.Process.Parent

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Args | process.parent.args | Array of process arguments. | ["/usr/bin/ssh", "-l", "user", "10.0.0.16"] |
| ArgsCount | process.parent.args_count | Length of the process.args array. | 4 |
| CommandLine | process.parent.command_line | Full command line that started the process. | /usr/bin/ssh -l user 10.0.0.16 |
| CommandLineText | process.parent.command_line.text | Full command line that started the process. | /usr/bin/ssh -l user 10.0.0.16 |
| End | process.parent.end | The time the process ended. | 2016-05-23T08:05:34.853Z |
| EntityId | process.parent.entity_id | Unique identifier for the process. | c2c455d9f99375d |
| Executable | process.parent.executable | Absolute path to the process executable. | /usr/bin/ssh |
| ExecutableText | process.parent.executable.text | Absolute path to the process executable. | /usr/bin/ssh |
| ExitCode | process.parent.exit_code | The exit code of the process. | 137 |
| Interactive | process.parent.interactive | Whether the process is connected to an interactive shell. | True |
| Name | process.parent.name | Process name. | ssh |
| NameText | process.parent.name.text | Process name. | ssh |
| Pgid | process.parent.pgid | Deprecated identifier of the group of processes the process belongs to. |  |
| Pid | process.parent.pid | Process id. | 4242 |
| Start | process.parent.start | The time the process started. | 2016-05-23T08:05:34.853Z |
| Title | process.parent.title | Process title. |  |
| TitleText | process.parent.title.text | Process title. |  |
| Tty | process.parent.tty | Information about the controlling TTY device. |  |
| Uptime | process.parent.uptime | Seconds the process has been up. | 1325 |
| WorkingDirectory | process.parent.working_directory | The working directory of the process. | /home/alice |
| WorkingDirectoryText | process.parent.working_directory.text | The working directory of the process. | /home/alice |

#### ECS.Process.Parent.CodeSignature

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| DigestAlgorithm | process.parent.code_signature.digest_algorithm | Hashing algorithm used to sign the process. | sha256 |
| Exists | process.parent.code_signature.exists | Boolean to capture if a signature is present. | true |
| SigningId | process.parent.code_signature.signing_id | The identifier used to sign the process. | com.apple.xpc.proxy |
| Status | process.parent.code_signature.status | Additional information about the certificate status. | ERROR_UNTRUSTED_ROOT |
| SubjectName | process.parent.code_signature.subject_name | Subject name of the code signer | Microsoft Corporation |
| TeamId | process.parent.code_signature.team_id | The team identifier used to sign the process. | EQHXZ8M8AV |
| Timestamp | process.parent.code_signature.timestamp | When the signature was generated and signed. | 2021-01-01T12:10:30Z |
| Trusted | process.parent.code_signature.trusted | Stores the trust status of the certificate chain. | true |
| Valid | process.parent.code_signature.valid | Boolean to capture if the digital signature is verified against the binary content. | true |

#### ECS.Process.Parent.Elf

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Architecture | process.parent.elf.architecture | Machine architecture of the ELF file. | x86-64 |
| ByteOrder | process.parent.elf.byte_order | Byte sequence of ELF file. | Little Endian |
| CpuType | process.parent.elf.cpu_type | CPU type of the ELF file. | Intel |
| CreationDate | process.parent.elf.creation_date | Build or compile date. |  |
| Exports | process.parent.elf.exports | List of exported element names and types. |  |
| GoImportHash | process.parent.elf.go_import_hash | A hash of the Go language imports in an ELF file. | 10bddcb4cee42080f76c88d9ff964491 |
| GoImports | process.parent.elf.go_imports | List of imported Go language element names and types. |  |
| GoImportsNamesEntropy | process.parent.elf.go_imports_names_entropy | Shannon entropy calculation from the list of Go imports. |  |
| GoImportsNamesVarEntropy | process.parent.elf.go_imports_names_var_entropy | Variance for Shannon entropy calculation from the list of Go imports. |  |
| GoStripped | process.parent.elf.go_stripped | Whether the file is a stripped or obfuscated Go executable. |  |
| ImportHash | process.parent.elf.import_hash | A hash of the imports in an ELF file. | d41d8cd98f00b204e9800998ecf8427e |
| Imports | process.parent.elf.imports | List of imported element names and types. |  |
| ImportsNamesEntropy | process.parent.elf.imports_names_entropy | Shannon entropy calculation from the list of imported element names and types. |  |
| ImportsNamesVarEntropy | process.parent.elf.imports_names_var_entropy | Variance for Shannon entropy calculation from the list of imported element names and types. |  |
| Sections | process.parent.elf.sections | Section information of the ELF file. |  |
| SectionsChi2 | process.parent.elf.sections.chi2 | Chi-square probability distribution of the section. |  |
| SectionsEntropy | process.parent.elf.sections.entropy | Shannon entropy calculation from the section. |  |
| SectionsFlags | process.parent.elf.sections.flags | ELF Section List flags. |  |
| SectionsName | process.parent.elf.sections.name | ELF Section List name. |  |
| SectionsPhysicalOffset | process.parent.elf.sections.physical_offset | ELF Section List offset. |  |
| SectionsPhysicalSize | process.parent.elf.sections.physical_size | ELF Section List physical size. |  |
| SectionsType | process.parent.elf.sections.type | ELF Section List type. |  |
| SectionsVarEntropy | process.parent.elf.sections.var_entropy | Variance for Shannon entropy calculation from the section. |  |
| SectionsVirtualAddress | process.parent.elf.sections.virtual_address | ELF Section List virtual address. |  |
| SectionsVirtualSize | process.parent.elf.sections.virtual_size | ELF Section List virtual size. |  |
| Segments | process.parent.elf.segments | ELF object segment list. |  |
| SegmentsSections | process.parent.elf.segments.sections | ELF object segment sections. |  |
| SegmentsType | process.parent.elf.segments.type | ELF object segment type. |  |
| SharedLibraries | process.parent.elf.shared_libraries | List of shared libraries used by this ELF object. |  |
| Telfhash | process.parent.elf.telfhash | telfhash hash for ELF file. |  |

##### ECS.Process.Parent.Elf.Header

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| AbiVersion | process.parent.elf.header.abi_version | Version of the ELF Application Binary Interface (ABI). |  |
| Class | process.parent.elf.header.class | Header class of the ELF file. |  |
| Data | process.parent.elf.header.data | Data table of the ELF header. |  |
| Entrypoint | process.parent.elf.header.entrypoint | Header entrypoint of the ELF file. |  |
| ObjectVersion | process.parent.elf.header.object_version | "0x1" for original ELF files. |  |
| OsAbi | process.parent.elf.header.os_abi | Application Binary Interface (ABI) of the Linux OS. |  |
| Type | process.parent.elf.header.type | Header type of the ELF file. |  |
| Version | process.parent.elf.header.version | Version of the ELF header. |  |

#### ECS.Process.Parent.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.parent.group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.parent.group.name | Name of the group. |  |

#### ECS.Process.Parent.GroupLeader

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| EntityId | process.parent.group_leader.entity_id | Unique identifier for the process. | c2c455d9f99375d |
| Pid | process.parent.group_leader.pid | Process id. | 4242 |
| Start | process.parent.group_leader.start | The time the process started. | 2016-05-23T08:05:34.853Z |

#### ECS.Process.Parent.Hash

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Md5 | process.parent.hash.md5 | MD5 hash. |  |
| Sha1 | process.parent.hash.sha1 | SHA1 hash. |  |
| Sha256 | process.parent.hash.sha256 | SHA256 hash. |  |
| Sha384 | process.parent.hash.sha384 | SHA384 hash. |  |
| Sha512 | process.parent.hash.sha512 | SHA512 hash. |  |
| Ssdeep | process.parent.hash.ssdeep | SSDEEP hash. |  |
| Tlsh | process.parent.hash.tlsh | TLSH hash. |  |

#### ECS.Process.Parent.Macho

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| GoImportHash | process.parent.macho.go_import_hash | A hash of the Go language imports in a Mach-O file. | 10bddcb4cee42080f76c88d9ff964491 |
| GoImports | process.parent.macho.go_imports | List of imported Go language element names and types. |  |
| GoImportsNamesEntropy | process.parent.macho.go_imports_names_entropy | Shannon entropy calculation from the list of Go imports. |  |
| GoImportsNamesVarEntropy | process.parent.macho.go_imports_names_var_entropy | Variance for Shannon entropy calculation from the list of Go imports. |  |
| GoStripped | process.parent.macho.go_stripped | Whether the file is a stripped or obfuscated Go executable. |  |
| ImportHash | process.parent.macho.import_hash | A hash of the imports in a Mach-O file. | d41d8cd98f00b204e9800998ecf8427e |
| Imports | process.parent.macho.imports | List of imported element names and types. |  |
| ImportsNamesEntropy | process.parent.macho.imports_names_entropy | Shannon entropy calculation from the list of imported element names and types. |  |
| ImportsNamesVarEntropy | process.parent.macho.imports_names_var_entropy | Variance for Shannon entropy calculation from the list of imported element names and types. |  |
| Sections | process.parent.macho.sections | Section information of the Mach-O file. |  |
| SectionsEntropy | process.parent.macho.sections.entropy | Shannon entropy calculation from the section. |  |
| SectionsName | process.parent.macho.sections.name | Mach-O Section List name. |  |
| SectionsPhysicalSize | process.parent.macho.sections.physical_size | Mach-O Section List physical size. |  |
| SectionsVarEntropy | process.parent.macho.sections.var_entropy | Variance for Shannon entropy calculation from the section. |  |
| SectionsVirtualSize | process.parent.macho.sections.virtual_size | Mach-O Section List virtual size. This is always the same as `physical_size`. |  |
| Symhash | process.parent.macho.symhash | A hash of the imports in a Mach-O file. | d3ccf195b62a9279c3c19af1080497ec |

#### ECS.Process.Parent.Pe

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Architecture | process.parent.pe.architecture | CPU architecture target for the file. | x64 |
| Company | process.parent.pe.company | Internal company name of the file, provided at compile-time. | Microsoft Corporation |
| Description | process.parent.pe.description | Internal description of the file, provided at compile-time. | Paint |
| FileVersion | process.parent.pe.file_version | Process name. | 6.3.9600.17415 |
| GoImportHash | process.parent.pe.go_import_hash | A hash of the Go language imports in a PE file. | 10bddcb4cee42080f76c88d9ff964491 |
| GoImports | process.parent.pe.go_imports | List of imported Go language element names and types. |  |
| GoImportsNamesEntropy | process.parent.pe.go_imports_names_entropy | Shannon entropy calculation from the list of Go imports. |  |
| GoImportsNamesVarEntropy | process.parent.pe.go_imports_names_var_entropy | Variance for Shannon entropy calculation from the list of Go imports. |  |
| GoStripped | process.parent.pe.go_stripped | Whether the file is a stripped or obfuscated Go executable. |  |
| Imphash | process.parent.pe.imphash | A hash of the imports in a PE file. | 0c6803c4e922103c4dca5963aad36ddf |
| ImportHash | process.parent.pe.import_hash | A hash of the imports in a PE file. | d41d8cd98f00b204e9800998ecf8427e |
| Imports | process.parent.pe.imports | List of imported element names and types. |  |
| ImportsNamesEntropy | process.parent.pe.imports_names_entropy | Shannon entropy calculation from the list of imported element names and types. |  |
| ImportsNamesVarEntropy | process.parent.pe.imports_names_var_entropy | Variance for Shannon entropy calculation from the list of imported element names and types. |  |
| OriginalFileName | process.parent.pe.original_file_name | Internal name of the file, provided at compile-time. | MSPAINT.EXE |
| Pehash | process.parent.pe.pehash | A hash of the PE header and data from one or more PE sections. | 73ff189b63cd6be375a7ff25179a38d347651975 |
| Product | process.parent.pe.product | Internal product name of the file, provided at compile-time. | Microsoft® Windows® Operating System |
| Sections | process.parent.pe.sections | Section information of the PE file. |  |
| SectionsEntropy | process.parent.pe.sections.entropy | Shannon entropy calculation from the section. |  |
| SectionsName | process.parent.pe.sections.name | PE Section List name. |  |
| SectionsPhysicalSize | process.parent.pe.sections.physical_size | PE Section List physical size. |  |
| SectionsVarEntropy | process.parent.pe.sections.var_entropy | Variance for Shannon entropy calculation from the section. |  |
| SectionsVirtualSize | process.parent.pe.sections.virtual_size | PE Section List virtual size. This is always the same as `physical_size`. |  |

#### ECS.Process.Parent.RealGroup

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.parent.real_group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.parent.real_group.name | Name of the group. |  |

#### ECS.Process.Parent.RealUser

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.parent.real_user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.parent.real_user.name | Short name or login of the user. | a.einstein |
| NameText | process.parent.real_user.name.text | Short name or login of the user. | a.einstein |

#### ECS.Process.Parent.SavedGroup

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.parent.saved_group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.parent.saved_group.name | Name of the group. |  |

#### ECS.Process.Parent.SavedUser

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.parent.saved_user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.parent.saved_user.name | Short name or login of the user. | a.einstein |
| NameText | process.parent.saved_user.name.text | Short name or login of the user. | a.einstein |

#### ECS.Process.Parent.SupplementalGroups

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.parent.supplemental_groups.id | Unique identifier for the group on the system/platform. |  |
| Name | process.parent.supplemental_groups.name | Name of the group. |  |

#### ECS.Process.Parent.Thread

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.parent.thread.id | Thread ID. | 4242 |
| Name | process.parent.thread.name | Thread name. | thread-0 |

#### ECS.Process.Parent.User

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.parent.user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.parent.user.name | Short name or login of the user. | a.einstein |
| NameText | process.parent.user.name.text | Short name or login of the user. | a.einstein |

### ECS.Process.Pe

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Architecture | process.pe.architecture | CPU architecture target for the file. | x64 |
| Company | process.pe.company | Internal company name of the file, provided at compile-time. | Microsoft Corporation |
| Description | process.pe.description | Internal description of the file, provided at compile-time. | Paint |
| FileVersion | process.pe.file_version | Process name. | 6.3.9600.17415 |
| GoImportHash | process.pe.go_import_hash | A hash of the Go language imports in a PE file. | 10bddcb4cee42080f76c88d9ff964491 |
| GoImports | process.pe.go_imports | List of imported Go language element names and types. |  |
| GoImportsNamesEntropy | process.pe.go_imports_names_entropy | Shannon entropy calculation from the list of Go imports. |  |
| GoImportsNamesVarEntropy | process.pe.go_imports_names_var_entropy | Variance for Shannon entropy calculation from the list of Go imports. |  |
| GoStripped | process.pe.go_stripped | Whether the file is a stripped or obfuscated Go executable. |  |
| Imphash | process.pe.imphash | A hash of the imports in a PE file. | 0c6803c4e922103c4dca5963aad36ddf |
| ImportHash | process.pe.import_hash | A hash of the imports in a PE file. | d41d8cd98f00b204e9800998ecf8427e |
| Imports | process.pe.imports | List of imported element names and types. |  |
| ImportsNamesEntropy | process.pe.imports_names_entropy | Shannon entropy calculation from the list of imported element names and types. |  |
| ImportsNamesVarEntropy | process.pe.imports_names_var_entropy | Variance for Shannon entropy calculation from the list of imported element names and types. |  |
| OriginalFileName | process.pe.original_file_name | Internal name of the file, provided at compile-time. | MSPAINT.EXE |
| Pehash | process.pe.pehash | A hash of the PE header and data from one or more PE sections. | 73ff189b63cd6be375a7ff25179a38d347651975 |
| Product | process.pe.product | Internal product name of the file, provided at compile-time. | Microsoft® Windows® Operating System |
| Sections | process.pe.sections | Section information of the PE file. |  |
| SectionsEntropy | process.pe.sections.entropy | Shannon entropy calculation from the section. |  |
| SectionsName | process.pe.sections.name | PE Section List name. |  |
| SectionsPhysicalSize | process.pe.sections.physical_size | PE Section List physical size. |  |
| SectionsVarEntropy | process.pe.sections.var_entropy | Variance for Shannon entropy calculation from the section. |  |
| SectionsVirtualSize | process.pe.sections.virtual_size | PE Section List virtual size. This is always the same as `physical_size`. |  |

### ECS.Process.Previous

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Args | process.previous.args | Array of process arguments. | ["/usr/bin/ssh", "-l", "user", "10.0.0.16"] |
| ArgsCount | process.previous.args_count | Length of the process.args array. | 4 |
| Executable | process.previous.executable | Absolute path to the process executable. | /usr/bin/ssh |
| ExecutableText | process.previous.executable.text | Absolute path to the process executable. | /usr/bin/ssh |

### ECS.Process.RealGroup

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.real_group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.real_group.name | Name of the group. |  |

### ECS.Process.RealUser

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.real_user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.real_user.name | Short name or login of the user. | a.einstein |
| NameText | process.real_user.name.text | Short name or login of the user. | a.einstein |

### ECS.Process.SavedGroup

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.saved_group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.saved_group.name | Name of the group. |  |

### ECS.Process.SavedUser

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.saved_user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.saved_user.name | Short name or login of the user. | a.einstein |
| NameText | process.saved_user.name.text | Short name or login of the user. | a.einstein |

### ECS.Process.SessionLeader

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Args | process.session_leader.args | Array of process arguments. | ["/usr/bin/ssh", "-l", "user", "10.0.0.16"] |
| ArgsCount | process.session_leader.args_count | Length of the process.args array. | 4 |
| CommandLine | process.session_leader.command_line | Full command line that started the process. | /usr/bin/ssh -l user 10.0.0.16 |
| CommandLineText | process.session_leader.command_line.text | Full command line that started the process. | /usr/bin/ssh -l user 10.0.0.16 |
| EntityId | process.session_leader.entity_id | Unique identifier for the process. | c2c455d9f99375d |
| Executable | process.session_leader.executable | Absolute path to the process executable. | /usr/bin/ssh |
| ExecutableText | process.session_leader.executable.text | Absolute path to the process executable. | /usr/bin/ssh |
| Interactive | process.session_leader.interactive | Whether the process is connected to an interactive shell. | True |
| Name | process.session_leader.name | Process name. | ssh |
| NameText | process.session_leader.name.text | Process name. | ssh |
| Pid | process.session_leader.pid | Process id. | 4242 |
| SameAsProcess | process.session_leader.same_as_process | This boolean is used to identify if a leader process is the same as the top level process. | True |
| Start | process.session_leader.start | The time the process started. | 2016-05-23T08:05:34.853Z |
| Tty | process.session_leader.tty | Information about the controlling TTY device. |  |
| WorkingDirectory | process.session_leader.working_directory | The working directory of the process. | /home/alice |
| WorkingDirectoryText | process.session_leader.working_directory.text | The working directory of the process. | /home/alice |

#### ECS.Process.SessionLeader.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.session_leader.group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.session_leader.group.name | Name of the group. |  |

#### ECS.Process.SessionLeader.Parent

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| EntityId | process.session_leader.parent.entity_id | Unique identifier for the process. | c2c455d9f99375d |
| Pid | process.session_leader.parent.pid | Process id. | 4242 |
| Start | process.session_leader.parent.start | The time the process started. | 2016-05-23T08:05:34.853Z |

##### ECS.Process.SessionLeader.Parent.SessionLeader

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| EntityId | process.session_leader.parent.session_leader.entity_id | Unique identifier for the process. | c2c455d9f99375d |
| Pid | process.session_leader.parent.session_leader.pid | Process id. | 4242 |
| Start | process.session_leader.parent.session_leader.start | The time the process started. | 2016-05-23T08:05:34.853Z |

#### ECS.Process.SessionLeader.RealGroup

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.session_leader.real_group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.session_leader.real_group.name | Name of the group. |  |

#### ECS.Process.SessionLeader.RealUser

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.session_leader.real_user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.session_leader.real_user.name | Short name or login of the user. | a.einstein |
| NameText | process.session_leader.real_user.name.text | Short name or login of the user. | a.einstein |

#### ECS.Process.SessionLeader.SavedGroup

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.session_leader.saved_group.id | Unique identifier for the group on the system/platform. |  |
| Name | process.session_leader.saved_group.name | Name of the group. |  |

#### ECS.Process.SessionLeader.SavedUser

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.session_leader.saved_user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.session_leader.saved_user.name | Short name or login of the user. | a.einstein |
| NameText | process.session_leader.saved_user.name.text | Short name or login of the user. | a.einstein |

#### ECS.Process.SessionLeader.SupplementalGroups

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.session_leader.supplemental_groups.id | Unique identifier for the group on the system/platform. |  |
| Name | process.session_leader.supplemental_groups.name | Name of the group. |  |

#### ECS.Process.SessionLeader.User

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.session_leader.user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.session_leader.user.name | Short name or login of the user. | a.einstein |
| NameText | process.session_leader.user.name.text | Short name or login of the user. | a.einstein |

### ECS.Process.SupplementalGroups

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.supplemental_groups.id | Unique identifier for the group on the system/platform. |  |
| Name | process.supplemental_groups.name | Name of the group. |  |

### ECS.Process.Thread

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.thread.id | Thread ID. | 4242 |
| Name | process.thread.name | Thread name. | thread-0 |

### ECS.Process.User

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | process.user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | process.user.name | Short name or login of the user. | a.einstein |
| NameText | process.user.name.text | Short name or login of the user. | a.einstein |

## ECS.Registry

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Hive | registry.hive | Abbreviated name for the hive. | HKLM |
| Key | registry.key | Hive-relative path of keys. | SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\winword.exe |
| Path | registry.path | Full path, including hive, key and value | HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\winword.exe\Debugger |
| Value | registry.value | Name of the value written. | Debugger |

### ECS.Registry.Data

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | registry.data.bytes | Original bytes written with base64 encoding. | ZQBuAC0AVQBTAAAAZQBuAAAAAAA= |
| Strings | registry.data.strings | List of strings representing what was written to the registry. | ["C:\rta\red_ttp\bin\myapp.exe"] |
| Type | registry.data.type | Standard registry type for encoding contents | REG_SZ |

## ECS.Related

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Hash | related.hash | All the hashes seen on your event. |  |
| Hosts | related.hosts | All the host identifiers seen on your event. |  |
| Ip | related.ip | All of the IPs seen on your event. |  |
| User | related.user | All the user names or other user identifiers seen on the event. |  |

## ECS.Rule

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Author | rule.author | Rule author | ["Star-Lord"] |
| Category | rule.category | Rule category | Attempted Information Leak |
| Description | rule.description | Rule description | Block requests to public DNS over HTTPS / TLS protocols |
| Id | rule.id | Rule ID | 101 |
| License | rule.license | Rule license | Apache 2.0 |
| Name | rule.name | Rule name | BLOCK_DNS_over_TLS |
| Reference | rule.reference | Rule reference URL | https://en.wikipedia.org/wiki/DNS_over_TLS |
| Ruleset | rule.ruleset | Rule ruleset | Standard_Protocol_Filters |
| Uuid | rule.uuid | Rule UUID | 1100110011 |
| Version | rule.version | Rule version | 1.1 |

## ECS.Server

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | server.address | Server network address. |  |
| Bytes | server.bytes | Bytes sent from the server to the client. | 184 |
| Domain | server.domain | The domain name of the server. | foo.example.com |
| Ip | server.ip | IP address of the server. |  |
| Mac | server.mac | MAC address of the server. | 00-00-5E-00-53-23 |
| Packets | server.packets | Packets sent from the server to the client. | 12 |
| Port | server.port | Port of the server. |  |
| RegisteredDomain | server.registered_domain | The highest registered server domain, stripped of the subdomain. | example.com |
| Subdomain | server.subdomain | The subdomain of the domain. | east |
| TopLevelDomain | server.top_level_domain | The effective top level domain (com, org, net, co.uk). | co.uk |

### ECS.Server.As

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Number | server.as.number | Unique number allocated to the autonomous system. | 15169 |

#### ECS.Server.As.Organization

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | server.as.organization.name | Organization name. | Google LLC |
| NameText | server.as.organization.name.text | Organization name. | Google LLC |

### ECS.Server.Geo

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CityName | server.geo.city_name | City name. | Montreal |
| ContinentCode | server.geo.continent_code | Continent code. | NA |
| ContinentName | server.geo.continent_name | Name of the continent. | North America |
| CountryIsoCode | server.geo.country_iso_code | Country ISO code. | CA |
| CountryName | server.geo.country_name | Country name. | Canada |
| Location | server.geo.location | Longitude and latitude. | { "lon": -73.614830, "lat": 45.505918 } |
| Name | server.geo.name | User-defined description of a location. | boston-dc |
| PostalCode | server.geo.postal_code | Postal code. | 94040 |
| RegionIsoCode | server.geo.region_iso_code | Region ISO code. | CA-QC |
| RegionName | server.geo.region_name | Region name. | Quebec |
| Timezone | server.geo.timezone | Time zone. | America/Argentina/Buenos_Aires |

### ECS.Server.Nat

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Ip | server.nat.ip | Server NAT ip |  |
| Port | server.nat.port | Server NAT port |  |

### ECS.Server.User

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | server.user.domain | Name of the directory the user is a member of. |  |
| Email | server.user.email | User email address. |  |
| FullName | server.user.full_name | User's full name, if available. | Albert Einstein |
| FullNameText | server.user.full_name.text | User's full name, if available. | Albert Einstein |
| Hash | server.user.hash | Unique user hash to correlate information for a user in anonymized form. |  |
| Id | server.user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | server.user.name | Short name or login of the user. | a.einstein |
| NameText | server.user.name.text | Short name or login of the user. | a.einstein |
| Roles | server.user.roles | Array of user roles at the time of the event. | ["kibana_admin", "reporting_user"] |

#### ECS.Server.User.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | server.user.group.domain | Name of the directory the group is a member of. |  |
| Id | server.user.group.id | Unique identifier for the group on the system/platform. |  |
| Name | server.user.group.name | Name of the group. |  |

## ECS.Service

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | service.address | Address of this service. | 172.26.0.2:5432 |
| Environment | service.environment | Environment of the service. | production |
| EphemeralId | service.ephemeral_id | Ephemeral identifier of this service. | 8a4f500f |
| Id | service.id | Unique identifier of the running service. | d37e5ebfe0ae6c4972dbe9f0174a1637bb8247f6 |
| Name | service.name | Name of the service. | elasticsearch-metrics |
| State | service.state | Current state of the service. |  |
| Type | service.type | The type of the service. | elasticsearch |
| Version | service.version | Version of the service. | 3.2.4 |

### ECS.Service.Node

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | service.node.name | Name of the service node. | instance-0000000016 |
| Role | service.node.role | Deprecated role (singular) of the service node. | background_tasks |
| Roles | service.node.roles | Roles of the service node. | ["ui", "background_tasks"] |

### ECS.Service.Origin

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | service.origin.address | Address of this service. | 172.26.0.2:5432 |
| Environment | service.origin.environment | Environment of the service. | production |
| EphemeralId | service.origin.ephemeral_id | Ephemeral identifier of this service. | 8a4f500f |
| Id | service.origin.id | Unique identifier of the running service. | d37e5ebfe0ae6c4972dbe9f0174a1637bb8247f6 |
| Name | service.origin.name | Name of the service. | elasticsearch-metrics |
| State | service.origin.state | Current state of the service. |  |
| Type | service.origin.type | The type of the service. | elasticsearch |
| Version | service.origin.version | Version of the service. | 3.2.4 |

#### ECS.Service.Origin.Node

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | service.origin.node.name | Name of the service node. | instance-0000000016 |
| Role | service.origin.node.role | Deprecated role (singular) of the service node. | background_tasks |
| Roles | service.origin.node.roles | Roles of the service node. | ["ui", "background_tasks"] |

### ECS.Service.Target

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | service.target.address | Address of this service. | 172.26.0.2:5432 |
| Environment | service.target.environment | Environment of the service. | production |
| EphemeralId | service.target.ephemeral_id | Ephemeral identifier of this service. | 8a4f500f |
| Id | service.target.id | Unique identifier of the running service. | d37e5ebfe0ae6c4972dbe9f0174a1637bb8247f6 |
| Name | service.target.name | Name of the service. | elasticsearch-metrics |
| State | service.target.state | Current state of the service. |  |
| Type | service.target.type | The type of the service. | elasticsearch |
| Version | service.target.version | Version of the service. | 3.2.4 |

#### ECS.Service.Target.Node

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | service.target.node.name | Name of the service node. | instance-0000000016 |
| Role | service.target.node.role | Deprecated role (singular) of the service node. | background_tasks |
| Roles | service.target.node.roles | Roles of the service node. | ["ui", "background_tasks"] |

## ECS.Source

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | source.address | Source network address. |  |
| Bytes | source.bytes | Bytes sent from the source to the destination. | 184 |
| Domain | source.domain | The domain name of the source. | foo.example.com |
| Ip | source.ip | IP address of the source. |  |
| Mac | source.mac | MAC address of the source. | 00-00-5E-00-53-23 |
| Packets | source.packets | Packets sent from the source to the destination. | 12 |
| Port | source.port | Port of the source. |  |
| RegisteredDomain | source.registered_domain | The highest registered source domain, stripped of the subdomain. | example.com |
| Subdomain | source.subdomain | The subdomain of the domain. | east |
| TopLevelDomain | source.top_level_domain | The effective top level domain (com, org, net, co.uk). | co.uk |

### ECS.Source.As

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Number | source.as.number | Unique number allocated to the autonomous system. | 15169 |

#### ECS.Source.As.Organization

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | source.as.organization.name | Organization name. | Google LLC |
| NameText | source.as.organization.name.text | Organization name. | Google LLC |

### ECS.Source.Geo

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CityName | source.geo.city_name | City name. | Montreal |
| ContinentCode | source.geo.continent_code | Continent code. | NA |
| ContinentName | source.geo.continent_name | Name of the continent. | North America |
| CountryIsoCode | source.geo.country_iso_code | Country ISO code. | CA |
| CountryName | source.geo.country_name | Country name. | Canada |
| Location | source.geo.location | Longitude and latitude. | { "lon": -73.614830, "lat": 45.505918 } |
| Name | source.geo.name | User-defined description of a location. | boston-dc |
| PostalCode | source.geo.postal_code | Postal code. | 94040 |
| RegionIsoCode | source.geo.region_iso_code | Region ISO code. | CA-QC |
| RegionName | source.geo.region_name | Region name. | Quebec |
| Timezone | source.geo.timezone | Time zone. | America/Argentina/Buenos_Aires |

### ECS.Source.Nat

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Ip | source.nat.ip | Source NAT ip |  |
| Port | source.nat.port | Source NAT port |  |

### ECS.Source.User

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | source.user.domain | Name of the directory the user is a member of. |  |
| Email | source.user.email | User email address. |  |
| FullName | source.user.full_name | User's full name, if available. | Albert Einstein |
| FullNameText | source.user.full_name.text | User's full name, if available. | Albert Einstein |
| Hash | source.user.hash | Unique user hash to correlate information for a user in anonymized form. |  |
| Id | source.user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | source.user.name | Short name or login of the user. | a.einstein |
| NameText | source.user.name.text | Short name or login of the user. | a.einstein |
| Roles | source.user.roles | Array of user roles at the time of the event. | ["kibana_admin", "reporting_user"] |

#### ECS.Source.User.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | source.user.group.domain | Name of the directory the group is a member of. |  |
| Id | source.user.group.id | Unique identifier for the group on the system/platform. |  |
| Name | source.user.group.name | Name of the group. |  |

## ECS.Span

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | span.id | Unique identifier of the span within the scope of its trace. | 3ff9a8981b7ccd5a |

## ECS.Threat

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Enrichments | threat.enrichments | List of objects containing indicators enriching the event. |  |
| EnrichmentsIndicator | threat.enrichments.indicator | Object containing indicators enriching the event. |  |
| Framework | threat.framework | Threat classification framework. | MITRE ATT&CK |

### ECS.Threat.Feed

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| DashboardId | threat.feed.dashboard_id | Feed dashboard ID. | 5ba16340-72e6-11eb-a3e3-b3cc7c78a70f |
| Description | threat.feed.description | Description of the threat feed. | Threat feed from the AlienVault Open Threat eXchange network. |
| Name | threat.feed.name | Name of the threat feed. | AlienVault OTX |
| Reference | threat.feed.reference | Reference for the threat feed. | https://otx.alienvault.com |

### ECS.Threat.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Alias | threat.group.alias | Alias of the group. | [ "Magecart Group 6" ] |
| Id | threat.group.id | ID of the group. | G0037 |
| Name | threat.group.name | Name of the group. | FIN6 |
| Reference | threat.group.reference | Reference URL of the group. | https://attack.mitre.org/groups/G0037/ |

### ECS.Threat.Indicator

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Confidence | threat.indicator.confidence | Indicator confidence rating | Medium |
| Description | threat.indicator.description | Indicator description | IP x.x.x.x was observed delivering the Angler EK. |
| FirstSeen | threat.indicator.first_seen | Date/time indicator was first reported. | 2020-11-05T17:25:47.000Z |
| Ip | threat.indicator.ip | Indicator IP address | 1.2.3.4 |
| LastSeen | threat.indicator.last_seen | Date/time indicator was last reported. | 2020-11-05T17:25:47.000Z |
| ModifiedAt | threat.indicator.modified_at | Date/time indicator was last updated. | 2020-11-05T17:25:47.000Z |
| Name | threat.indicator.name | Indicator display name | 5.2.75.227 |
| Port | threat.indicator.port | Indicator port | 443 |
| Provider | threat.indicator.provider | Indicator provider | lrz_urlhaus |
| Reference | threat.indicator.reference | Indicator reference URL | https://system.example.com/indicator/0001234 |
| ScannerStats | threat.indicator.scanner_stats | Scanner statistics | 4 |
| Sightings | threat.indicator.sightings | Number of times indicator observed | 20 |
| Type | threat.indicator.type | Type of indicator | ipv4-addr |

#### ECS.Threat.Indicator.As

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Number | threat.indicator.as.number | Unique number allocated to the autonomous system. | 15169 |

##### ECS.Threat.Indicator.As.Organization

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | threat.indicator.as.organization.name | Organization name. | Google LLC |
| NameText | threat.indicator.as.organization.name.text | Organization name. | Google LLC |

#### ECS.Threat.Indicator.Email

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Address | threat.indicator.email.address | Indicator email address | phish@example.com |

#### ECS.Threat.Indicator.File

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Accessed | threat.indicator.file.accessed | Last time the file was accessed. |  |
| Attributes | threat.indicator.file.attributes | Array of file attributes. | ["readonly", "system"] |
| Created | threat.indicator.file.created | File creation time. |  |
| Ctime | threat.indicator.file.ctime | Last time the file attributes or metadata changed. |  |
| Device | threat.indicator.file.device | Device that is the source of the file. | sda |
| Directory | threat.indicator.file.directory | Directory where the file is located. | /home/alice |
| DriveLetter | threat.indicator.file.drive_letter | Drive letter where the file is located. | C |
| Extension | threat.indicator.file.extension | File extension, excluding the leading dot. | png |
| ForkName | threat.indicator.file.fork_name | A fork is additional data associated with a filesystem object. | Zone.Identifer |
| Gid | threat.indicator.file.gid | Primary group ID (GID) of the file. | 1001 |
| Group | threat.indicator.file.group | Primary group name of the file. | alice |
| Inode | threat.indicator.file.inode | Inode representing the file in the filesystem. | 256383 |
| MimeType | threat.indicator.file.mime_type | Media type of file, document, or arrangement of bytes. |  |
| Mode | threat.indicator.file.mode | Mode of the file in octal representation. | 0640 |
| Mtime | threat.indicator.file.mtime | Last time the file content was modified. |  |
| Name | threat.indicator.file.name | Name of the file including the extension, without the directory. | example.png |
| Owner | threat.indicator.file.owner | File owner's username. | alice |
| Path | threat.indicator.file.path | Full path to the file, including the file name. | /home/alice/example.png |
| PathText | threat.indicator.file.path.text | Full path to the file, including the file name. | /home/alice/example.png |
| Size | threat.indicator.file.size | File size in bytes. | 16384 |
| TargetPath | threat.indicator.file.target_path | Target path for symlinks. |  |
| TargetPathText | threat.indicator.file.target_path.text | Target path for symlinks. |  |
| Type | threat.indicator.file.type | File type (file, dir, or symlink). | file |
| Uid | threat.indicator.file.uid | The user ID (UID) or security identifier (SID) of the file owner. | 1001 |

##### ECS.Threat.Indicator.File.CodeSignature

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| DigestAlgorithm | threat.indicator.file.code_signature.digest_algorithm | Hashing algorithm used to sign the process. | sha256 |
| Exists | threat.indicator.file.code_signature.exists | Boolean to capture if a signature is present. | true |
| SigningId | threat.indicator.file.code_signature.signing_id | The identifier used to sign the process. | com.apple.xpc.proxy |
| Status | threat.indicator.file.code_signature.status | Additional information about the certificate status. | ERROR_UNTRUSTED_ROOT |
| SubjectName | threat.indicator.file.code_signature.subject_name | Subject name of the code signer | Microsoft Corporation |
| TeamId | threat.indicator.file.code_signature.team_id | The team identifier used to sign the process. | EQHXZ8M8AV |
| Timestamp | threat.indicator.file.code_signature.timestamp | When the signature was generated and signed. | 2021-01-01T12:10:30Z |
| Trusted | threat.indicator.file.code_signature.trusted | Stores the trust status of the certificate chain. | true |
| Valid | threat.indicator.file.code_signature.valid | Boolean to capture if the digital signature is verified against the binary content. | true |

##### ECS.Threat.Indicator.File.Elf

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Architecture | threat.indicator.file.elf.architecture | Machine architecture of the ELF file. | x86-64 |
| ByteOrder | threat.indicator.file.elf.byte_order | Byte sequence of ELF file. | Little Endian |
| CpuType | threat.indicator.file.elf.cpu_type | CPU type of the ELF file. | Intel |
| CreationDate | threat.indicator.file.elf.creation_date | Build or compile date. |  |
| Exports | threat.indicator.file.elf.exports | List of exported element names and types. |  |
| GoImportHash | threat.indicator.file.elf.go_import_hash | A hash of the Go language imports in an ELF file. | 10bddcb4cee42080f76c88d9ff964491 |
| GoImports | threat.indicator.file.elf.go_imports | List of imported Go language element names and types. |  |
| GoImportsNamesEntropy | threat.indicator.file.elf.go_imports_names_entropy | Shannon entropy calculation from the list of Go imports. |  |
| GoImportsNamesVarEntropy | threat.indicator.file.elf.go_imports_names_var_entropy | Variance for Shannon entropy calculation from the list of Go imports. |  |
| GoStripped | threat.indicator.file.elf.go_stripped | Whether the file is a stripped or obfuscated Go executable. |  |
| ImportHash | threat.indicator.file.elf.import_hash | A hash of the imports in an ELF file. | d41d8cd98f00b204e9800998ecf8427e |
| Imports | threat.indicator.file.elf.imports | List of imported element names and types. |  |
| ImportsNamesEntropy | threat.indicator.file.elf.imports_names_entropy | Shannon entropy calculation from the list of imported element names and types. |  |
| ImportsNamesVarEntropy | threat.indicator.file.elf.imports_names_var_entropy | Variance for Shannon entropy calculation from the list of imported element names and types. |  |
| Sections | threat.indicator.file.elf.sections | Section information of the ELF file. |  |
| SectionsChi2 | threat.indicator.file.elf.sections.chi2 | Chi-square probability distribution of the section. |  |
| SectionsEntropy | threat.indicator.file.elf.sections.entropy | Shannon entropy calculation from the section. |  |
| SectionsFlags | threat.indicator.file.elf.sections.flags | ELF Section List flags. |  |
| SectionsName | threat.indicator.file.elf.sections.name | ELF Section List name. |  |
| SectionsPhysicalOffset | threat.indicator.file.elf.sections.physical_offset | ELF Section List offset. |  |
| SectionsPhysicalSize | threat.indicator.file.elf.sections.physical_size | ELF Section List physical size. |  |
| SectionsType | threat.indicator.file.elf.sections.type | ELF Section List type. |  |
| SectionsVarEntropy | threat.indicator.file.elf.sections.var_entropy | Variance for Shannon entropy calculation from the section. |  |
| SectionsVirtualAddress | threat.indicator.file.elf.sections.virtual_address | ELF Section List virtual address. |  |
| SectionsVirtualSize | threat.indicator.file.elf.sections.virtual_size | ELF Section List virtual size. |  |
| Segments | threat.indicator.file.elf.segments | ELF object segment list. |  |
| SegmentsSections | threat.indicator.file.elf.segments.sections | ELF object segment sections. |  |
| SegmentsType | threat.indicator.file.elf.segments.type | ELF object segment type. |  |
| SharedLibraries | threat.indicator.file.elf.shared_libraries | List of shared libraries used by this ELF object. |  |
| Telfhash | threat.indicator.file.elf.telfhash | telfhash hash for ELF file. |  |

###### ECS.Threat.Indicator.File.Elf.Header

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| AbiVersion | threat.indicator.file.elf.header.abi_version | Version of the ELF Application Binary Interface (ABI). |  |
| Class | threat.indicator.file.elf.header.class | Header class of the ELF file. |  |
| Data | threat.indicator.file.elf.header.data | Data table of the ELF header. |  |
| Entrypoint | threat.indicator.file.elf.header.entrypoint | Header entrypoint of the ELF file. |  |
| ObjectVersion | threat.indicator.file.elf.header.object_version | "0x1" for original ELF files. |  |
| OsAbi | threat.indicator.file.elf.header.os_abi | Application Binary Interface (ABI) of the Linux OS. |  |
| Type | threat.indicator.file.elf.header.type | Header type of the ELF file. |  |
| Version | threat.indicator.file.elf.header.version | Version of the ELF header. |  |

##### ECS.Threat.Indicator.File.Hash

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Md5 | threat.indicator.file.hash.md5 | MD5 hash. |  |
| Sha1 | threat.indicator.file.hash.sha1 | SHA1 hash. |  |
| Sha256 | threat.indicator.file.hash.sha256 | SHA256 hash. |  |
| Sha384 | threat.indicator.file.hash.sha384 | SHA384 hash. |  |
| Sha512 | threat.indicator.file.hash.sha512 | SHA512 hash. |  |
| Ssdeep | threat.indicator.file.hash.ssdeep | SSDEEP hash. |  |
| Tlsh | threat.indicator.file.hash.tlsh | TLSH hash. |  |

##### ECS.Threat.Indicator.File.Pe

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Architecture | threat.indicator.file.pe.architecture | CPU architecture target for the file. | x64 |
| Company | threat.indicator.file.pe.company | Internal company name of the file, provided at compile-time. | Microsoft Corporation |
| Description | threat.indicator.file.pe.description | Internal description of the file, provided at compile-time. | Paint |
| FileVersion | threat.indicator.file.pe.file_version | Process name. | 6.3.9600.17415 |
| GoImportHash | threat.indicator.file.pe.go_import_hash | A hash of the Go language imports in a PE file. | 10bddcb4cee42080f76c88d9ff964491 |
| GoImports | threat.indicator.file.pe.go_imports | List of imported Go language element names and types. |  |
| GoImportsNamesEntropy | threat.indicator.file.pe.go_imports_names_entropy | Shannon entropy calculation from the list of Go imports. |  |
| GoImportsNamesVarEntropy | threat.indicator.file.pe.go_imports_names_var_entropy | Variance for Shannon entropy calculation from the list of Go imports. |  |
| GoStripped | threat.indicator.file.pe.go_stripped | Whether the file is a stripped or obfuscated Go executable. |  |
| Imphash | threat.indicator.file.pe.imphash | A hash of the imports in a PE file. | 0c6803c4e922103c4dca5963aad36ddf |
| ImportHash | threat.indicator.file.pe.import_hash | A hash of the imports in a PE file. | d41d8cd98f00b204e9800998ecf8427e |
| Imports | threat.indicator.file.pe.imports | List of imported element names and types. |  |
| ImportsNamesEntropy | threat.indicator.file.pe.imports_names_entropy | Shannon entropy calculation from the list of imported element names and types. |  |
| ImportsNamesVarEntropy | threat.indicator.file.pe.imports_names_var_entropy | Variance for Shannon entropy calculation from the list of imported element names and types. |  |
| OriginalFileName | threat.indicator.file.pe.original_file_name | Internal name of the file, provided at compile-time. | MSPAINT.EXE |
| Pehash | threat.indicator.file.pe.pehash | A hash of the PE header and data from one or more PE sections. | 73ff189b63cd6be375a7ff25179a38d347651975 |
| Product | threat.indicator.file.pe.product | Internal product name of the file, provided at compile-time. | Microsoft® Windows® Operating System |
| Sections | threat.indicator.file.pe.sections | Section information of the PE file. |  |
| SectionsEntropy | threat.indicator.file.pe.sections.entropy | Shannon entropy calculation from the section. |  |
| SectionsName | threat.indicator.file.pe.sections.name | PE Section List name. |  |
| SectionsPhysicalSize | threat.indicator.file.pe.sections.physical_size | PE Section List physical size. |  |
| SectionsVarEntropy | threat.indicator.file.pe.sections.var_entropy | Variance for Shannon entropy calculation from the section. |  |
| SectionsVirtualSize | threat.indicator.file.pe.sections.virtual_size | PE Section List virtual size. This is always the same as `physical_size`. |  |

##### ECS.Threat.Indicator.File.X509

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| AlternativeNames | threat.indicator.file.x509.alternative_names | List of subject alternative names (SAN). | *.elastic.co |
| NotAfter | threat.indicator.file.x509.not_after | Time at which the certificate is no longer considered valid. | 2020-07-16T03:15:39Z |
| NotBefore | threat.indicator.file.x509.not_before | Time at which the certificate is first considered valid. | 2019-08-16T01:40:25Z |
| PublicKeyAlgorithm | threat.indicator.file.x509.public_key_algorithm | Algorithm used to generate the public key. | RSA |
| PublicKeyCurve | threat.indicator.file.x509.public_key_curve | The curve used by the elliptic curve public key algorithm. This is algorithm specific. | nistp521 |
| PublicKeyExponent | threat.indicator.file.x509.public_key_exponent | Exponent used to derive the public key. This is algorithm specific. | 65537 |
| PublicKeySize | threat.indicator.file.x509.public_key_size | The size of the public key space in bits. | 2048 |
| SerialNumber | threat.indicator.file.x509.serial_number | Unique serial number issued by the certificate authority. | 55FBB9C7DEBF09809D12CCAA |
| SignatureAlgorithm | threat.indicator.file.x509.signature_algorithm | Identifier for certificate signature algorithm. | SHA256-RSA |
| VersionNumber | threat.indicator.file.x509.version_number | Version of x509 format. | 3 |

###### ECS.Threat.Indicator.File.X509.Issuer

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CommonName | threat.indicator.file.x509.issuer.common_name | List of common name (CN) of issuing certificate authority. | Example SHA2 High Assurance Server CA |
| Country | threat.indicator.file.x509.issuer.country | List of country \(C) codes | US |
| DistinguishedName | threat.indicator.file.x509.issuer.distinguished_name | Distinguished name (DN) of issuing certificate authority. | C=US, O=Example Inc, OU=www.example.com, CN=Example SHA2 High Assurance Server CA |
| Locality | threat.indicator.file.x509.issuer.locality | List of locality names (L) | Mountain View |
| Organization | threat.indicator.file.x509.issuer.organization | List of organizations (O) of issuing certificate authority. | Example Inc |
| OrganizationalUnit | threat.indicator.file.x509.issuer.organizational_unit | List of organizational units (OU) of issuing certificate authority. | www.example.com |
| StateOrProvince | threat.indicator.file.x509.issuer.state_or_province | List of state or province names (ST, S, or P) | California |

###### ECS.Threat.Indicator.File.X509.Subject

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CommonName | threat.indicator.file.x509.subject.common_name | List of common names (CN) of subject. | shared.global.example.net |
| Country | threat.indicator.file.x509.subject.country | List of country \(C) code | US |
| DistinguishedName | threat.indicator.file.x509.subject.distinguished_name | Distinguished name (DN) of the certificate subject entity. | C=US, ST=California, L=San Francisco, O=Example, Inc., CN=shared.global.example.net |
| Locality | threat.indicator.file.x509.subject.locality | List of locality names (L) | San Francisco |
| Organization | threat.indicator.file.x509.subject.organization | List of organizations (O) of subject. | Example, Inc. |
| OrganizationalUnit | threat.indicator.file.x509.subject.organizational_unit | List of organizational units (OU) of subject. |  |
| StateOrProvince | threat.indicator.file.x509.subject.state_or_province | List of state or province names (ST, S, or P) | California |

#### ECS.Threat.Indicator.Geo

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CityName | threat.indicator.geo.city_name | City name. | Montreal |
| ContinentCode | threat.indicator.geo.continent_code | Continent code. | NA |
| ContinentName | threat.indicator.geo.continent_name | Name of the continent. | North America |
| CountryIsoCode | threat.indicator.geo.country_iso_code | Country ISO code. | CA |
| CountryName | threat.indicator.geo.country_name | Country name. | Canada |
| Location | threat.indicator.geo.location | Longitude and latitude. | { "lon": -73.614830, "lat": 45.505918 } |
| Name | threat.indicator.geo.name | User-defined description of a location. | boston-dc |
| PostalCode | threat.indicator.geo.postal_code | Postal code. | 94040 |
| RegionIsoCode | threat.indicator.geo.region_iso_code | Region ISO code. | CA-QC |
| RegionName | threat.indicator.geo.region_name | Region name. | Quebec |
| Timezone | threat.indicator.geo.timezone | Time zone. | America/Argentina/Buenos_Aires |

#### ECS.Threat.Indicator.Marking

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Tlp | threat.indicator.marking.tlp | Indicator TLP marking | CLEAR |
| TlpVersion | threat.indicator.marking.tlp_version | Indicator TLP version | 2.0 |

#### ECS.Threat.Indicator.Registry

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Hive | threat.indicator.registry.hive | Abbreviated name for the hive. | HKLM |
| Key | threat.indicator.registry.key | Hive-relative path of keys. | SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\winword.exe |
| Path | threat.indicator.registry.path | Full path, including hive, key and value | HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\winword.exe\Debugger |
| Value | threat.indicator.registry.value | Name of the value written. | Debugger |

##### ECS.Threat.Indicator.Registry.Data

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Bytes | threat.indicator.registry.data.bytes | Original bytes written with base64 encoding. | ZQBuAC0AVQBTAAAAZQBuAAAAAAA= |
| Strings | threat.indicator.registry.data.strings | List of strings representing what was written to the registry. | ["C:\rta\red_ttp\bin\myapp.exe"] |
| Type | threat.indicator.registry.data.type | Standard registry type for encoding contents | REG_SZ |

#### ECS.Threat.Indicator.Url

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | threat.indicator.url.domain | Domain of the url. | www.elastic.co |
| Extension | threat.indicator.url.extension | File extension from the request url, excluding the leading dot. | png |
| Fragment | threat.indicator.url.fragment | Portion of the url after the `#`. |  |
| Full | threat.indicator.url.full | Full unparsed URL. | https://www.elastic.co:443/search?q=elasticsearch#top |
| FullText | threat.indicator.url.full.text | Full unparsed URL. | https://www.elastic.co:443/search?q=elasticsearch#top |
| Original | threat.indicator.url.original | Unmodified original url as seen in the event source. | https://www.elastic.co:443/search?q=elasticsearch#top or /search?q=elasticsearch |
| OriginalText | threat.indicator.url.original.text | Unmodified original url as seen in the event source. | https://www.elastic.co:443/search?q=elasticsearch#top or /search?q=elasticsearch |
| Password | threat.indicator.url.password | Password of the request. |  |
| Path | threat.indicator.url.path | Path of the request, such as "/search". |  |
| Port | threat.indicator.url.port | Port of the request, such as 443. | 443 |
| Query | threat.indicator.url.query | Query string of the request. |  |
| RegisteredDomain | threat.indicator.url.registered_domain | The highest registered url domain, stripped of the subdomain. | example.com |
| Scheme | threat.indicator.url.scheme | Scheme of the url. | https |
| Subdomain | threat.indicator.url.subdomain | The subdomain of the domain. | east |
| TopLevelDomain | threat.indicator.url.top_level_domain | The effective top level domain (com, org, net, co.uk). | co.uk |
| Username | threat.indicator.url.username | Username of the request. |  |

#### ECS.Threat.Indicator.X509

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| AlternativeNames | threat.indicator.x509.alternative_names | List of subject alternative names (SAN). | *.elastic.co |
| NotAfter | threat.indicator.x509.not_after | Time at which the certificate is no longer considered valid. | 2020-07-16T03:15:39Z |
| NotBefore | threat.indicator.x509.not_before | Time at which the certificate is first considered valid. | 2019-08-16T01:40:25Z |
| PublicKeyAlgorithm | threat.indicator.x509.public_key_algorithm | Algorithm used to generate the public key. | RSA |
| PublicKeyCurve | threat.indicator.x509.public_key_curve | The curve used by the elliptic curve public key algorithm. This is algorithm specific. | nistp521 |
| PublicKeyExponent | threat.indicator.x509.public_key_exponent | Exponent used to derive the public key. This is algorithm specific. | 65537 |
| PublicKeySize | threat.indicator.x509.public_key_size | The size of the public key space in bits. | 2048 |
| SerialNumber | threat.indicator.x509.serial_number | Unique serial number issued by the certificate authority. | 55FBB9C7DEBF09809D12CCAA |
| SignatureAlgorithm | threat.indicator.x509.signature_algorithm | Identifier for certificate signature algorithm. | SHA256-RSA |
| VersionNumber | threat.indicator.x509.version_number | Version of x509 format. | 3 |

##### ECS.Threat.Indicator.X509.Issuer

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CommonName | threat.indicator.x509.issuer.common_name | List of common name (CN) of issuing certificate authority. | Example SHA2 High Assurance Server CA |
| Country | threat.indicator.x509.issuer.country | List of country \(C) codes | US |
| DistinguishedName | threat.indicator.x509.issuer.distinguished_name | Distinguished name (DN) of issuing certificate authority. | C=US, O=Example Inc, OU=www.example.com, CN=Example SHA2 High Assurance Server CA |
| Locality | threat.indicator.x509.issuer.locality | List of locality names (L) | Mountain View |
| Organization | threat.indicator.x509.issuer.organization | List of organizations (O) of issuing certificate authority. | Example Inc |
| OrganizationalUnit | threat.indicator.x509.issuer.organizational_unit | List of organizational units (OU) of issuing certificate authority. | www.example.com |
| StateOrProvince | threat.indicator.x509.issuer.state_or_province | List of state or province names (ST, S, or P) | California |

##### ECS.Threat.Indicator.X509.Subject

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CommonName | threat.indicator.x509.subject.common_name | List of common names (CN) of subject. | shared.global.example.net |
| Country | threat.indicator.x509.subject.country | List of country \(C) code | US |
| DistinguishedName | threat.indicator.x509.subject.distinguished_name | Distinguished name (DN) of the certificate subject entity. | C=US, ST=California, L=San Francisco, O=Example, Inc., CN=shared.global.example.net |
| Locality | threat.indicator.x509.subject.locality | List of locality names (L) | San Francisco |
| Organization | threat.indicator.x509.subject.organization | List of organizations (O) of subject. | Example, Inc. |
| OrganizationalUnit | threat.indicator.x509.subject.organizational_unit | List of organizational units (OU) of subject. |  |
| StateOrProvince | threat.indicator.x509.subject.state_or_province | List of state or province names (ST, S, or P) | California |

### ECS.Threat.Software

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Alias | threat.software.alias | Alias of the software | [ "X-Agent" ] |
| Id | threat.software.id | ID of the software | S0552 |
| Name | threat.software.name | Name of the software. | AdFind |
| Platforms | threat.software.platforms | Platforms of the software. | [ "Windows" ] |
| Reference | threat.software.reference | Software reference URL. | https://attack.mitre.org/software/S0552/ |
| Type | threat.software.type | Software type. | Tool |

### ECS.Threat.Tactic

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | threat.tactic.id | Threat tactic id. | TA0002 |
| Name | threat.tactic.name | Threat tactic. | Execution |
| Reference | threat.tactic.reference | Threat tactic URL reference. | https://attack.mitre.org/tactics/TA0002/ |

### ECS.Threat.Technique

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | threat.technique.id | Threat technique id. | T1059 |
| Name | threat.technique.name | Threat technique name. | Command and Scripting Interpreter |
| NameText | threat.technique.name.text | Threat technique name. | Command and Scripting Interpreter |
| Reference | threat.technique.reference | Threat technique URL reference. | https://attack.mitre.org/techniques/T1059/ |

#### ECS.Threat.Technique.Subtechnique

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | threat.technique.subtechnique.id | Threat subtechnique id. | T1059.001 |
| Name | threat.technique.subtechnique.name | Threat subtechnique name. | PowerShell |
| NameText | threat.technique.subtechnique.name.text | Threat subtechnique name. | PowerShell |
| Reference | threat.technique.subtechnique.reference | Threat subtechnique URL reference. | https://attack.mitre.org/techniques/T1059/001/ |

## ECS.Tls

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Cipher | tls.cipher | String indicating the cipher used during the current connection. | TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 |
| Curve | tls.curve | String indicating the curve used for the given cipher, when applicable. | secp256r1 |
| Established | tls.established | Boolean flag indicating if the TLS negotiation was successful and transitioned to an encrypted tunnel. |  |
| NextProtocol | tls.next_protocol | String indicating the protocol being tunneled. | http/1.1 |
| Resumed | tls.resumed | Boolean flag indicating if this TLS connection was resumed from an existing TLS negotiation. |  |
| Version | tls.version | Numeric part of the version parsed from the original string. | 1.2 |
| VersionProtocol | tls.version_protocol | Normalized lowercase protocol name parsed from original string. | tls |

### ECS.Tls.Client

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Certificate | tls.client.certificate | PEM-encoded stand-alone certificate offered by the client. | MII... |
| CertificateChain | tls.client.certificate_chain | Array of PEM-encoded certificates that make up the certificate chain offered by the client. | ["MII...", "MII..."] |
| Issuer | tls.client.issuer | Distinguished name of subject of the issuer of the x.509 certificate presented by the client. | CN=Example Root CA, OU=Infrastructure Team, DC=example, DC=com |
| Ja3 | tls.client.ja3 | A hash that identifies clients based on how they perform an SSL/TLS handshake. | d4e5b18d6b55c71272893221c96ba240 |
| NotAfter | tls.client.not_after | Date/Time indicating when client certificate is no longer considered valid. | 2021-01-01T00:00:00.000Z |
| NotBefore | tls.client.not_before | Date/Time indicating when client certificate is first considered valid. | 1970-01-01T00:00:00.000Z |
| ServerName | tls.client.server_name | Hostname the client is trying to connect to. Also called the SNI. | www.elastic.co |
| Subject | tls.client.subject | Distinguished name of subject of the x.509 certificate presented by the client. | CN=myclient, OU=Documentation Team, DC=example, DC=com |
| SupportedCiphers | tls.client.supported_ciphers | Array of ciphers offered by the client during the client hello. | ["TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384", "TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384", "..."] |

#### ECS.Tls.Client.Hash

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Md5 | tls.client.hash.md5 | Certificate fingerprint using the MD5 digest of DER-encoded version of certificate offered by the client. | 0F76C7F2C55BFD7D8E8B8F4BFBF0C9EC |
| Sha1 | tls.client.hash.sha1 | Certificate fingerprint using the SHA1 digest of DER-encoded version of certificate offered by the client. | 9E393D93138888D288266C2D915214D1D1CCEB2A |
| Sha256 | tls.client.hash.sha256 | Certificate fingerprint using the SHA256 digest of DER-encoded version of certificate offered by the client. | 0687F666A054EF17A08E2F2162EAB4CBC0D265E1D7875BE74BF3C712CA92DAF0 |

#### ECS.Tls.Client.X509

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| AlternativeNames | tls.client.x509.alternative_names | List of subject alternative names (SAN). | *.elastic.co |
| NotAfter | tls.client.x509.not_after | Time at which the certificate is no longer considered valid. | 2020-07-16T03:15:39Z |
| NotBefore | tls.client.x509.not_before | Time at which the certificate is first considered valid. | 2019-08-16T01:40:25Z |
| PublicKeyAlgorithm | tls.client.x509.public_key_algorithm | Algorithm used to generate the public key. | RSA |
| PublicKeyCurve | tls.client.x509.public_key_curve | The curve used by the elliptic curve public key algorithm. This is algorithm specific. | nistp521 |
| PublicKeyExponent | tls.client.x509.public_key_exponent | Exponent used to derive the public key. This is algorithm specific. | 65537 |
| PublicKeySize | tls.client.x509.public_key_size | The size of the public key space in bits. | 2048 |
| SerialNumber | tls.client.x509.serial_number | Unique serial number issued by the certificate authority. | 55FBB9C7DEBF09809D12CCAA |
| SignatureAlgorithm | tls.client.x509.signature_algorithm | Identifier for certificate signature algorithm. | SHA256-RSA |
| VersionNumber | tls.client.x509.version_number | Version of x509 format. | 3 |

##### ECS.Tls.Client.X509.Issuer

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CommonName | tls.client.x509.issuer.common_name | List of common name (CN) of issuing certificate authority. | Example SHA2 High Assurance Server CA |
| Country | tls.client.x509.issuer.country | List of country \(C) codes | US |
| DistinguishedName | tls.client.x509.issuer.distinguished_name | Distinguished name (DN) of issuing certificate authority. | C=US, O=Example Inc, OU=www.example.com, CN=Example SHA2 High Assurance Server CA |
| Locality | tls.client.x509.issuer.locality | List of locality names (L) | Mountain View |
| Organization | tls.client.x509.issuer.organization | List of organizations (O) of issuing certificate authority. | Example Inc |
| OrganizationalUnit | tls.client.x509.issuer.organizational_unit | List of organizational units (OU) of issuing certificate authority. | www.example.com |
| StateOrProvince | tls.client.x509.issuer.state_or_province | List of state or province names (ST, S, or P) | California |

##### ECS.Tls.Client.X509.Subject

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CommonName | tls.client.x509.subject.common_name | List of common names (CN) of subject. | shared.global.example.net |
| Country | tls.client.x509.subject.country | List of country \(C) code | US |
| DistinguishedName | tls.client.x509.subject.distinguished_name | Distinguished name (DN) of the certificate subject entity. | C=US, ST=California, L=San Francisco, O=Example, Inc., CN=shared.global.example.net |
| Locality | tls.client.x509.subject.locality | List of locality names (L) | San Francisco |
| Organization | tls.client.x509.subject.organization | List of organizations (O) of subject. | Example, Inc. |
| OrganizationalUnit | tls.client.x509.subject.organizational_unit | List of organizational units (OU) of subject. |  |
| StateOrProvince | tls.client.x509.subject.state_or_province | List of state or province names (ST, S, or P) | California |

### ECS.Tls.Server

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Certificate | tls.server.certificate | PEM-encoded stand-alone certificate offered by the server. | MII... |
| CertificateChain | tls.server.certificate_chain | Array of PEM-encoded certificates that make up the certificate chain offered by the server. | ["MII...", "MII..."] |
| Issuer | tls.server.issuer | Subject of the issuer of the x.509 certificate presented by the server. | CN=Example Root CA, OU=Infrastructure Team, DC=example, DC=com |
| Ja3s | tls.server.ja3s | A hash that identifies servers based on how they perform an SSL/TLS handshake. | 394441ab65754e2207b1e1b457b3641d |
| NotAfter | tls.server.not_after | Timestamp indicating when server certificate is no longer considered valid. | 2021-01-01T00:00:00.000Z |
| NotBefore | tls.server.not_before | Timestamp indicating when server certificate is first considered valid. | 1970-01-01T00:00:00.000Z |
| Subject | tls.server.subject | Subject of the x.509 certificate presented by the server. | CN=www.example.com, OU=Infrastructure Team, DC=example, DC=com |

#### ECS.Tls.Server.Hash

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Md5 | tls.server.hash.md5 | Certificate fingerprint using the MD5 digest of DER-encoded version of certificate offered by the server. | 0F76C7F2C55BFD7D8E8B8F4BFBF0C9EC |
| Sha1 | tls.server.hash.sha1 | Certificate fingerprint using the SHA1 digest of DER-encoded version of certificate offered by the server. | 9E393D93138888D288266C2D915214D1D1CCEB2A |
| Sha256 | tls.server.hash.sha256 | Certificate fingerprint using the SHA256 digest of DER-encoded version of certificate offered by the server. | 0687F666A054EF17A08E2F2162EAB4CBC0D265E1D7875BE74BF3C712CA92DAF0 |

#### ECS.Tls.Server.X509

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| AlternativeNames | tls.server.x509.alternative_names | List of subject alternative names (SAN). | *.elastic.co |
| NotAfter | tls.server.x509.not_after | Time at which the certificate is no longer considered valid. | 2020-07-16T03:15:39Z |
| NotBefore | tls.server.x509.not_before | Time at which the certificate is first considered valid. | 2019-08-16T01:40:25Z |
| PublicKeyAlgorithm | tls.server.x509.public_key_algorithm | Algorithm used to generate the public key. | RSA |
| PublicKeyCurve | tls.server.x509.public_key_curve | The curve used by the elliptic curve public key algorithm. This is algorithm specific. | nistp521 |
| PublicKeyExponent | tls.server.x509.public_key_exponent | Exponent used to derive the public key. This is algorithm specific. | 65537 |
| PublicKeySize | tls.server.x509.public_key_size | The size of the public key space in bits. | 2048 |
| SerialNumber | tls.server.x509.serial_number | Unique serial number issued by the certificate authority. | 55FBB9C7DEBF09809D12CCAA |
| SignatureAlgorithm | tls.server.x509.signature_algorithm | Identifier for certificate signature algorithm. | SHA256-RSA |
| VersionNumber | tls.server.x509.version_number | Version of x509 format. | 3 |

##### ECS.Tls.Server.X509.Issuer

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CommonName | tls.server.x509.issuer.common_name | List of common name (CN) of issuing certificate authority. | Example SHA2 High Assurance Server CA |
| Country | tls.server.x509.issuer.country | List of country \(C) codes | US |
| DistinguishedName | tls.server.x509.issuer.distinguished_name | Distinguished name (DN) of issuing certificate authority. | C=US, O=Example Inc, OU=www.example.com, CN=Example SHA2 High Assurance Server CA |
| Locality | tls.server.x509.issuer.locality | List of locality names (L) | Mountain View |
| Organization | tls.server.x509.issuer.organization | List of organizations (O) of issuing certificate authority. | Example Inc |
| OrganizationalUnit | tls.server.x509.issuer.organizational_unit | List of organizational units (OU) of issuing certificate authority. | www.example.com |
| StateOrProvince | tls.server.x509.issuer.state_or_province | List of state or province names (ST, S, or P) | California |

##### ECS.Tls.Server.X509.Subject

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CommonName | tls.server.x509.subject.common_name | List of common names (CN) of subject. | shared.global.example.net |
| Country | tls.server.x509.subject.country | List of country \(C) code | US |
| DistinguishedName | tls.server.x509.subject.distinguished_name | Distinguished name (DN) of the certificate subject entity. | C=US, ST=California, L=San Francisco, O=Example, Inc., CN=shared.global.example.net |
| Locality | tls.server.x509.subject.locality | List of locality names (L) | San Francisco |
| Organization | tls.server.x509.subject.organization | List of organizations (O) of subject. | Example, Inc. |
| OrganizationalUnit | tls.server.x509.subject.organizational_unit | List of organizational units (OU) of subject. |  |
| StateOrProvince | tls.server.x509.subject.state_or_province | List of state or province names (ST, S, or P) | California |

## ECS.Trace

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | trace.id | Unique identifier of the trace. | 4bf92f3577b34da6a3ce929d0e0e4736 |

## ECS.Transaction

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Id | transaction.id | Unique identifier of the transaction within the scope of its trace. | 00f067aa0ba902b7 |

## ECS.Url

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | url.domain | Domain of the url. | www.elastic.co |
| Extension | url.extension | File extension from the request url, excluding the leading dot. | png |
| Fragment | url.fragment | Portion of the url after the `#`. |  |
| Full | url.full | Full unparsed URL. | https://www.elastic.co:443/search?q=elasticsearch#top |
| FullText | url.full.text | Full unparsed URL. | https://www.elastic.co:443/search?q=elasticsearch#top |
| Original | url.original | Unmodified original url as seen in the event source. | https://www.elastic.co:443/search?q=elasticsearch#top or /search?q=elasticsearch |
| OriginalText | url.original.text | Unmodified original url as seen in the event source. | https://www.elastic.co:443/search?q=elasticsearch#top or /search?q=elasticsearch |
| Password | url.password | Password of the request. |  |
| Path | url.path | Path of the request, such as "/search". |  |
| Port | url.port | Port of the request, such as 443. | 443 |
| Query | url.query | Query string of the request. |  |
| RegisteredDomain | url.registered_domain | The highest registered url domain, stripped of the subdomain. | example.com |
| Scheme | url.scheme | Scheme of the url. | https |
| Subdomain | url.subdomain | The subdomain of the domain. | east |
| TopLevelDomain | url.top_level_domain | The effective top level domain (com, org, net, co.uk). | co.uk |
| Username | url.username | Username of the request. |  |

## ECS.User

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | user.domain | Name of the directory the user is a member of. |  |
| Email | user.email | User email address. |  |
| FullName | user.full_name | User's full name, if available. | Albert Einstein |
| FullNameText | user.full_name.text | User's full name, if available. | Albert Einstein |
| Hash | user.hash | Unique user hash to correlate information for a user in anonymized form. |  |
| Id | user.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | user.name | Short name or login of the user. | a.einstein |
| NameText | user.name.text | Short name or login of the user. | a.einstein |
| Roles | user.roles | Array of user roles at the time of the event. | ["kibana_admin", "reporting_user"] |

### ECS.User.Changes

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | user.changes.domain | Name of the directory the user is a member of. |  |
| Email | user.changes.email | User email address. |  |
| FullName | user.changes.full_name | User's full name, if available. | Albert Einstein |
| FullNameText | user.changes.full_name.text | User's full name, if available. | Albert Einstein |
| Hash | user.changes.hash | Unique user hash to correlate information for a user in anonymized form. |  |
| Id | user.changes.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | user.changes.name | Short name or login of the user. | a.einstein |
| NameText | user.changes.name.text | Short name or login of the user. | a.einstein |
| Roles | user.changes.roles | Array of user roles at the time of the event. | ["kibana_admin", "reporting_user"] |

#### ECS.User.Changes.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | user.changes.group.domain | Name of the directory the group is a member of. |  |
| Id | user.changes.group.id | Unique identifier for the group on the system/platform. |  |
| Name | user.changes.group.name | Name of the group. |  |

### ECS.User.Effective

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | user.effective.domain | Name of the directory the user is a member of. |  |
| Email | user.effective.email | User email address. |  |
| FullName | user.effective.full_name | User's full name, if available. | Albert Einstein |
| FullNameText | user.effective.full_name.text | User's full name, if available. | Albert Einstein |
| Hash | user.effective.hash | Unique user hash to correlate information for a user in anonymized form. |  |
| Id | user.effective.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | user.effective.name | Short name or login of the user. | a.einstein |
| NameText | user.effective.name.text | Short name or login of the user. | a.einstein |
| Roles | user.effective.roles | Array of user roles at the time of the event. | ["kibana_admin", "reporting_user"] |

#### ECS.User.Effective.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | user.effective.group.domain | Name of the directory the group is a member of. |  |
| Id | user.effective.group.id | Unique identifier for the group on the system/platform. |  |
| Name | user.effective.group.name | Name of the group. |  |

### ECS.User.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | user.group.domain | Name of the directory the group is a member of. |  |
| Id | user.group.id | Unique identifier for the group on the system/platform. |  |
| Name | user.group.name | Name of the group. |  |

### ECS.User.Risk

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| CalculatedLevel | user.risk.calculated_level | A risk classification level calculated by an internal system as part of entity analytics and entity risk scoring. | High |
| CalculatedScore | user.risk.calculated_score | A risk classification score calculated by an internal system as part of entity analytics and entity risk scoring. | 880.73 |
| CalculatedScoreNorm | user.risk.calculated_score_norm | A normalized risk score calculated by an internal system. | 88.73 |
| StaticLevel | user.risk.static_level | A risk classification level obtained from outside the system, such as from some external Threat Intelligence Platform. | High |
| StaticScore | user.risk.static_score | A risk classification score obtained from outside the system, such as from some external Threat Intelligence Platform. | 830.0 |
| StaticScoreNorm | user.risk.static_score_norm | A normalized risk score calculated by an external system. | 83.0 |

### ECS.User.Target

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | user.target.domain | Name of the directory the user is a member of. |  |
| Email | user.target.email | User email address. |  |
| FullName | user.target.full_name | User's full name, if available. | Albert Einstein |
| FullNameText | user.target.full_name.text | User's full name, if available. | Albert Einstein |
| Hash | user.target.hash | Unique user hash to correlate information for a user in anonymized form. |  |
| Id | user.target.id | Unique identifier of the user. | S-1-5-21-202424912787-2692429404-2351956786-1000 |
| Name | user.target.name | Short name or login of the user. | a.einstein |
| NameText | user.target.name.text | Short name or login of the user. | a.einstein |
| Roles | user.target.roles | Array of user roles at the time of the event. | ["kibana_admin", "reporting_user"] |

#### ECS.User.Target.Group

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Domain | user.target.group.domain | Name of the directory the group is a member of. |  |
| Id | user.target.group.id | Unique identifier for the group on the system/platform. |  |
| Name | user.target.group.name | Name of the group. |  |

## ECS.UserAgent

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | user_agent.name | Name of the user agent. | Safari |
| Original | user_agent.original | Unparsed user_agent string. | Mozilla/5.0 (iPhone; CPU iPhone OS 12_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 Mobile/15E148 Safari/604.1 |
| OriginalText | user_agent.original.text | Unparsed user_agent string. | Mozilla/5.0 (iPhone; CPU iPhone OS 12_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 Mobile/15E148 Safari/604.1 |
| Version | user_agent.version | Version of the user agent. | 12.0 |

### ECS.UserAgent.Device

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Name | user_agent.device.name | Name of the device. | iPhone |

### ECS.UserAgent.Os

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Family | user_agent.os.family | OS family (such as redhat, debian, freebsd, windows). | debian |
| Full | user_agent.os.full | Operating system name, including the version or code name. | Mac OS Mojave |
| FullText | user_agent.os.full.text | Operating system name, including the version or code name. | Mac OS Mojave |
| Kernel | user_agent.os.kernel | Operating system kernel version as a raw string. | 4.4.0-112-generic |
| Name | user_agent.os.name | Operating system name, without the version. | Mac OS X |
| NameText | user_agent.os.name.text | Operating system name, without the version. | Mac OS X |
| Platform | user_agent.os.platform | Operating system platform (such centos, ubuntu, windows). | darwin |
| Type | user_agent.os.type | Which commercial OS family (one of: linux, macos, unix, windows, ios or android). | macos |
| Version | user_agent.os.version | Operating system version as a raw string. | 10.14.1 |

## ECS.Vulnerability

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Category | vulnerability.category | Category of a vulnerability. | ["Firewall"] |
| Classification | vulnerability.classification | Classification of the vulnerability. | CVSS |
| Description | vulnerability.description | Description of the vulnerability. | In macOS before 2.12.6, there is a vulnerability in the RPC... |
| DescriptionText | vulnerability.description.text | Description of the vulnerability. | In macOS before 2.12.6, there is a vulnerability in the RPC... |
| Enumeration | vulnerability.enumeration | Identifier of the vulnerability. | CVE |
| Id | vulnerability.id | ID of the vulnerability. | CVE-2019-00001 |
| Reference | vulnerability.reference | Reference of the vulnerability. | https://cve.mitre.org/cgi-bin/cvename.cgi?name=CVE-2019-6111 |
| ReportId | vulnerability.report_id | Scan identification number. | 20191018.0001 |
| Severity | vulnerability.severity | Severity of the vulnerability. | Critical |

### ECS.Vulnerability.Scanner

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Vendor | vulnerability.scanner.vendor | Name of the scanner vendor. | Tenable |

### ECS.Vulnerability.Score

**Fields**

| Field | ECS Name | Description | Example |
| ----- | ----- | ----------- | ------- |
| Base | vulnerability.score.base | Vulnerability Base score. | 5.5 |
| Environmental | vulnerability.score.environmental | Vulnerability Environmental score. | 5.5 |
| Temporal | vulnerability.score.temporal | Vulnerability Temporal score. |  |
| Version | vulnerability.score.version | CVSS version. | 2.0 |

