﻿using NUnit.Framework;

namespace Whois.Domains
{
    [TestFixture]
    public class DomainTests
    {
        private WhoisLookup lookup;

        [SetUp]
        public void SetUp()
        {
            lookup = new WhoisLookup();
        }

        [Test]
        public void TestLookupCom()
        {
            var result = lookup.Lookup("001hosting.com.br");

            Assert.AreEqual(@"
% Copyright (c) Nic.br
%  The use of the data below is only permitted as described in
%  full by the terms of use at https://registro.br/termo/en.html ,
%  being prohibited its distribution, commercialization or
%  reproduction, in particular, to use it for advertising or
%  any similar purpose.
%  2019-04-30T07:03:56-03:00

domain:      001hosting.com.br
owner:       Ultra Provedor
ownerid:     350.562.738-05
country:     BR
owner-c:     ULPRO5
admin-c:     ULPRO5
tech-c:      ULPRO5
billing-c:   ULPRO5
nserver:     ns1.ultraprovedor.com.br
nsstat:      20190425 AA
nslastaa:    20190425
nserver:     ns2.ultraprovedor.com.br
nsstat:      20190425 AA
nslastaa:    20190425
nserver:     ns3.ultraprovedor.com.br
nsstat:      20190425 AA
nslastaa:    20190425
created:     20010919 #645178
changed:     20190406
expires:     20200919
status:      published

nic-hdl-br:  ULPRO5
person:      Ultra Provedor
e-mail:      registro@ultraprovedor.com.br
country:     BR
created:     20180226
changed:     20180226

% Security and mail abuse issues should also be addressed to
% cert.br, http://www.cert.br/ , respectivelly to cert@cert.br
% and mail-abuse@cert.br
%
% whois.registro.br accepts only direct match queries. Types
% of queries are: domain (.br), registrant (tax ID), ticket,
% provider, contact handle (ID), CIDR block, IP and ASN.", result.Content);
        }
    }
}
