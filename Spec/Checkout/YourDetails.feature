﻿Feature: YourDetails
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@tradefinancemagazine.com
Scenario Outline: Checkout - YourDetails - Should register with any US state
	Given Given I've selected basic subscription
	When I register with new email
	And I create a new account for US with any <State> and <PostCode>
	Then I should subscribe successfully
	Examples: 
		| State                | PostCode |
		| ALABAMA              | 00000    |
		| ALASKA               | 00000    |
		| ARIZONA              | 00000    |
		| ARKANSAS             | 00000    |
		| ARMED FORCES AMERICA | 34099    |
		| ARMED FORCES EUROPE  | 00000    |
		| ARMED FORCES PACIFIC | 34002    |
		| CALIFORNIA           | 00000    |
		| COLORADO             | 00000    |
		| CONNECTICUT          | 00000    |
		| DELAWARE             | 00000    |
		| DISTRICT OF COLUMBIA | 00000    |
		| FLORIDA              | 00000    |
		| GEORGIA              | 00000    |
		| HAWAII               | 00000    |
		| IDAHO                | 00000    |
		| ILLINOIS             | 00000    |
		| INDIANA              | 00000    |
		| IOWA                 | 00000    |
		| KANSAS               | 00000    |
		| KENTUCKY             | 00000    |
		| LOUISIANA            | 00000    |
		| MAINE                | 00000    |
		| MARYLAND             | 00000    |
		| MASSACHUSETTS        | 00000    |
		| MICHIGAN             | 00000    |
		| MINNESOTA            | 00000    |
		| MISSISSIPPI          | 00000    |
		| MISSOURI             | 00000    |
		| MONTANA              | 00000    |
		| NEBRASKA             | 00000    |
		| NEVADA               | 00000    |
		| NEW HAMPSHIRE        | 00000    |
		| NEW JERSEY           | 00000    |
		| NEW MEXICO           | 00000    |
		| NEW YORK             | 00000    |
		| NORTH CAROLINA       | 00000    |
		| NORTH DAKOTA         | 00000    |
		| OHIO                 | 00000    |
		| OKLAHOMA             | 00000    |
		| OREGON               | 00000    |
		| PENNSYLVANIA         | 00000    |
		| RHODE ISLAND         | 00000    |
		| SOUTH CAROLINA       | 00000    |
		| SOUTH DAKOTA         | 00000    |
		| TENNESSEE            | 00000    |
		| TEXAS                | 00000    |
		| UTAH                 | 00000    |
		| VERMONT              | 00000    |
		| VIRGINIA             | 00000    |
		| WASHINGTON           | 00000    |
		| WEST VIRGINIA        | 00000    |
		| WISCONSIN            | 00000    |
		| WYOMING              | 00000    |
		| GUAM                 | 00000    |
		| PUERTO RICO          | 00000    |
		| VIRGIN ISLANDS       | 00000    |

@tradefinancemagazine.com
Scenario Outline: Checkout - YourDetails - Should register with any Canadian province
	Given Given I've selected basic subscription
	When I register with new email
	And I create a new account for Canada with any <Province> and <PostCode>
	Then I should subscribe successfully
	Examples: 
		| Province | PostCode |
		|ALBERTA|T4G 0K1|
		|BRITISH COLUMBIA|V0K 0A7|
		|MANITOBA|R0K 0A0|
		|NEW BRUNSWICK|E4Y 1R3|
		|NEWFOUNDLAND AND LABRADOR|A0N 1A0|
		|NORTHWEST TERRITORIES|X0E 0A0|
		|NOVA SCOTIA|B0N 2H0|
		|NUNAVUT|X0A 0A0|
		|ONTARIO|L7J 0A1|
		|PRINCE EDWARD ISLAND|C0A 1H1|
		|QUEBEC|J0E 1B0|
		|SASKATCHEWAN|S0N 0A0|
		|YUKON TERRITORY|Y1A 0A1|

		
@tradefinancemagazine.com
Scenario Outline: Checkout - YourDetails - Should register with any country
	Given Given I've selected basic subscription
	When I register with new email
	And I create a new account with any <Country>
	Then I should subscribe successfully
	Examples: 
		| Country                                    |
		| Afghanistan                                |
		| Aland Islands                              |
		| Albania                                    |
		| Algeria                                    |
		| American Samoa                             |
		| Andorra                                    |
		| Angola                                     |
		| Anguilla                                   |
		| Antarctica                                 |
		| Antigua and Barbuda                        |
		| Argentina                                  |
		| Armenia                                    |
		| Aruba                                      |
		| Australia                                  |
		| Austria                                    |
		| Azerbaijan                                 |
		| Bahamas                                    |
		| Bahrain                                    |
		| Bangladesh                                 |
		| Barbados                                   |
		| Belarus                                    |
		| Belgium                                    |
		| Belize                                     |
		| Benin                                      |
		| Bermuda                                    |
		| Bhutan                                     |
		| Bolivia, Plurinational State of            |
		| Bonaire, Sint Eustatius and Saba           |
		| Bosnia and Herzegovina                     |
		| Botswana                                   |
		| Bouvet Island                              |
		| Brazil                                     |
		| British Indian Ocean Territory             |
		| Brunei Darussalam                          |
		| Bulgaria                                   |
		| Burkina Faso                               |
		| Burundi                                    |
		| Cambodia                                   |
		| Cameroon                                   |
		| Canada                                     |
		| Cape Verde                                 |
		| Cayman Islands                             |
		| Central African Republic                   |
		| Chad                                       |
		| Chile                                      |
		| China                                      |
		| Christmas Island                           |
		| Cocos (Keeling) Islands                    |
		| Colombia                                   |
		| Comoros                                    |
		| Congo                                      |
		| Congo, the Democratic Republic of the      |
		| Cook Islands                               |
		| Costa Rica                                 |
		| Cote d'Ivoire                              |
		| Croatia                                    |
		| Cuba                                       |
		| Curaçao                                    |
		| Cyprus                                     |
		| Czech Republic                             |
		| Denmark                                    |
		| Djibouti                                   |
		| Dominica                                   |
		| Dominican Republic                         |
		| Ecuador                                    |
		| Egypt                                      |
		| El Salvador                                |
		| Equatorial Guinea                          |
		| Eritrea                                    |
		| Estonia                                    |
		| Ethiopia                                   |
		| Falkland Islands (Malvinas)                |
		| Faroe Islands                              |
		| Fiji                                       |
		| Finland                                    |
		| France                                     |
		| French Guiana                              |
		| French Polynesia                           |
		| French Southern Territories                |
		| Gabon                                      |
		| Gambia                                     |
		| Georgia                                    |
		| Germany                                    |
		| Ghana                                      |
		| Gibraltar                                  |
		| Greece                                     |
		| Greenland                                  |
		| Grenada                                    |
		| Guadeloupe                                 |
		| Guam                                       |
		| Guatemala                                  |
		| Guernsey                                   |
		| Guinea                                     |
		| Guinea-Bissau                              |
		| Guyana                                     |
		| Haiti                                      |
		| Heard Island and McDonald Islands          |
		| Holy See (Vatican City State)              |
		| Honduras                                   |
		| Hong Kong                                  |
		| Hungary                                    |
		| Iceland                                    |
		| India                                      |
		| Indonesia                                  |
		| Iran, Islamic Republic of                  |
		| Iraq                                       |
		| Ireland                                    |
		| Isle of Man                                |
		| Israel                                     |
		| Italy                                      |
		| Jamaica                                    |
		| Japan                                      |
		| Jersey                                     |
		| Jordan                                     |
		| Kazakhstan                                 |
		| Kenya                                      |
		| Kiribati                                   |
		| Korea, Democratic People's Republic of     |
		| Korea, Republic of                         |
		| Kuwait                                     |
		| Kyrgyzstan                                 |
		| Lao People's Democratic Republic           |
		| Latvia                                     |
		| Lebanon                                    |
		| Lesotho                                    |
		| Liberia                                    |
		| Libya                                      |
		| Liechtenstein                              |
		| Lithuania                                  |
		| Luxembourg                                 |
		| Macao                                      |
		| Macedonia, the former Yugoslav Republic of |
		| Madagascar                                 |
		| Malawi                                     |
		| Malaysia                                   |
		| Maldives                                   |
		| Mali                                       |
		| Malta                                      |
		| Marshall Islands                           |
		| Martinique                                 |
		| Mauritania                                 |
		| Mauritius                                  |
		| Mayotte                                    |
		| Mexico                                     |
		| Micronesia, Federated States of            |
		| Moldova, Republic of                       |
		| Monaco                                     |
		| Mongolia                                   |
		| Montenegro                                 |
		| Montserrat                                 |
		| Morocco                                    |
		| Mozambique                                 |
		| Myanmar                                    |
		| Namibia                                    |
		| Nauru                                      |
		| Nepal                                      |
		| Netherlands                                |
		| New Caledonia                              |
		| New Zealand                                |
		| Nicaragua                                  |
		| Niger                                      |
		| Nigeria                                    |
		| Niue                                       |
		| Norfolk Island                             |
		| Northern Mariana Islands                   |
		| Norway                                     |
		| Oman                                       |
		| Pakistan                                   |
		| Palau                                      |
		| Palestinian Territory, Occupied            |
		| Panama                                     |
		| Papua New Guinea                           |
		| Paraguay                                   |
		| Peru                                       |
		| Philippines                                |
		| Pitcairn                                   |
		| Poland                                     |
		| Portugal                                   |
		| Puerto Rico                                |
		| Qatar                                      |
		| Réunion                                    |
		| Romania                                      |
		| Russian Federation                           |
		| Rwanda                                       |
		| Saint Barthélemy                             |
		| Saint Helena, Ascension and Tristan da Cunha |
		| Saint Kitts and Nevis                        |
		| Saint Lucia                                  |
		| Saint Martin (French part)                   |
		| Saint Pierre and Miquelon                    |
		| Saint Vincent and the Grenadines             |
		| Samoa                                        |
		| San Marino                                   |
		| Sao Tome and Principe                        |
		| Saudi Arabia                                 |
		| Senegal                                      |
		| Serbia                                       |
		| Seychelles                                   |
		| Sierra Leone                                 |
		| Singapore                                    |
		| Sint Maarten (Dutch part)                    |
		| Slovakia                                     |
		| Slovenia                                     |
		| Solomon Islands                              |
		| Somalia                                      |
		| South Africa                                 |
		| South Georgia and the South Sandwich Islands |
		| South Sudan                                  |
		| Spain                                        |
		| Sri Lanka                                    |
		| Sudan                                        |
		| Suriname                                     |
		| Svalbard and Jan Mayen                       |
		| Swaziland                                    |
		| Sweden                                       |
		| Switzerland                                  |
		| Syrian Arab Republic                         |
		| Taiwan, Province of China                    |
		| Tajikistan                                   |
		| Tanzania, United Republic of                 |
		| Thailand                                     |
		| Timor-Leste                                  |
		| Togo                                         |
		| Tokelau                                      |
		| Tonga                                        |
		| Trinidad and Tobago                          |
		| Tunisia                                      |
		| Turkey                                       |
		| Turkmenistan                                 |
		| Turks and Caicos Islands                     |
		| Tuvalu                                       |
		| Uganda                                       |
		| Ukraine                                      |
		| United Arab Emirates                         |
		| United Kingdom                               |
		| United States                                |
		| United States Minor Outlying Islands         |
		| Uruguay                                      |
		| Uzbekistan                                   |
		| Vanuatu                                      |
		| Venezuela, Bolivarian Republic of            |
		| Viet Nam                                     |
		| Virgin Islands, British                      |
		| Virgin Islands, U.S.                         |
		| Wallis and Futuna                            |
		| Western Sahara                               |
		| Yemen                                        |
		| Zambia                                       |
		| Zimbabwe                                     |
		| Netherlands Antiles                          |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should register with any allowed name
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new account with allowed name <FirstName> and <LastName>
		Then I should subscribe successfully
Examples: 
		| FirstName                                                    | LastName                                                     |
		| John                                                         | Smith                                                        |
		| sixty46C470FBA07993D61B46B54FA4F3CD444BA68AEAE0F0DCA197E04F6 | sixty46C470FBA07993D61B46B54FA4F3CD444BA68AEAE0F0DCA197E04F6 |
		| Test-                                                        | Test-                                                        |
		| Test.                                                        | Test.                                                        |
		| Test/                                                        | Test/                                                        |
		| Test+                                                        | Test+                                                        |
		| Test,                                                        | Test,                                                        |
		| Test:                                                        | Test:                                                        |
		| Test@                                                        | Test@                                                        |
		| Test?                                                        | Test?                                                        |
		| Test(                                                        | Test(                                                        |
		| Test)                                                        | Test)                                                        |
		| Test!                                                        | Test!                                                        |
		| Test'                                                        | Test'                                                        |
		| Test"                                                        | Test"                                                        |
		| Test&                                                        | Test&                                                        |
		| Test0123456789                                               | Test0123456789                                               |
		| qwertyuiopasdfghjklzxcvbnm                                   | qwertyuiopasdfghjklzxcvbnm                                   |
		| G1ͰͱͲͳʹ͵Ͷͷͺͻͼͽ;                                              | ͰͱͲͳʹ͵Ͷͷͺͻͼͽ;                                                |
		| G2B΄΅Ά·ΈΉΊΌΎΏΐΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟ                                | ΄΅Ά·ΈΉΊΌΎΏΐΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟ                                   |
		| G3CΠΡΣΤΥΦΧΨΩΪΫάέήίΰαβγδεζηθικλμνξο                           | ΠΡΣΤΥΦΧΨΩΪΫάέήίΰαβγδεζηθικλμνξο                              |
		| G4πρςστυφχψωϊϋόύώϏ                                           | πρςστυφχψωϊϋόύώϏ                                             |
		| G5ϐϑϒϓϔϕϖϗϘϙϚϛϜϝϞϟ                                           | ϐϑϒϓϔϕϖϗϘϙϚϛϜϝϞϟ                                             |
		| G6ϠϡϢϣϤϥϦϧϨϩϪϫϬϭϮϯ                                           | ϠϡϢϣϤϥϦϧϨϩϪϫϬϭϮϯ                                             |
		| G7ϰϱϲϳϴϵ϶ϷϸϹϺϻϼϽϾϿ                                           | ϰϱϲϳϴϵ϶ϷϸϹϺϻϼϽϾϿ                                             |
		| R1ЀЁЂЃЄЅІЇЈЉЊЋЌЍЎЏАБВГД                                      | ЀЁЂЃЄЅІЇЈЉЊЋЌЍЎЏАБВГД                                        |
		| R2ЕЖЗИЙКЛМНОПРСТУФХ                                          | ЕЖЗИЙКЛМНОПРСТУФХ                                            |
		| R3ЦЧШЩЪЫЬЭЮЯабвгде                                           | ЦЧШЩЪЫЬЭЮЯабвгде                                             |
		| R4жзийклмнопрстуфхцчшщъ                                      | жзийклмнопрстуфхцчшщъ                                        |
		| R5ыьэюяѐёђѓєѕіїјљњћќѝў                                       | ыьэюяѐёђѓєѕіїјљњћќѝў                                         |
		| R6џѠѡѢѣѤѥѦѧѨѩѪѫѬѭ                                            | џѠѡѢѣѤѥѦѧѨѩѪѫѬѭ                                              |
		| R7ѮѯѰѱѲѳѴѵѶѷѸѹѺѻ                                             | ѮѯѰѱѲѳѴѵѶѷѸѹѺѻ                                               |
		| R8ѼѽѾѿҀҁ҂҃҄҅҆҇҈҉ҊҋҌҍҎҏ                                       | ѼѽѾѿҀҁ҂҃҄҅҆҇҈҉ҊҋҌҍҎҏ                                         |
		| R9ҐґҒғҔҕҖҗҘҙҚқҜҝҞҟ                                           | ҐґҒғҔҕҖҗҘҙҚқҜҝҞҟ                                             |
		| R10ҠҡҢңҤҥҦҧҨҩҪ                                               | ҠҡҢңҤҥҦҧҨҩҪ                                                  |
		| R11ҫҬҭҮүҰұҲҳҴҵҶҷҸ                                            | ҫҬҭҮүҰұҲҳҴҵҶҷҸ                                               |
		| R12ҹҺһҼҽҾҿӀӁӂӃӄӅӆӇӈ                                          | ҹҺһҼҽҾҿӀӁӂӃӄӅӆӇӈ                                             |
		| R13ӉӊӋӌӍӎӏӐӑӒӓӔӕӖӗӘә                                         | ӉӊӋӌӍӎӏӐӑӒӓӔӕӖӗӘә                                            |
		| R14ӚӛӜӝӞӟӠӡӢӣӤӥӦӧ                                            | ӚӛӜӝӞӟӠӡӢӣӤӥӦӧ                                               |
		| R15ӨөӪӫӬӭӮӯӰӱӲӳӴӵӶӷӸӹӺӻӼӽӾӿ                                  | ӨөӪӫӬӭӮӯӰӱӲӳӴӵӶӷӸӹӺӻӼӽӾӿ                                     |
		| R16ԀԁԂԃԄԅԆԇԈԉԊԋԌԍԎԏԐԑԒԓԔԕԖ                                   | ԀԁԂԃԄԅԆԇԈԉԊԋԌԍԎԏԐԑԒԓԔԕԖ                                      |
		| R17ԗԘԙԚԛԜԝԞԟԠԡԢԣԤԥ                                         | ԗԘԙԚԛԜԝԞԟԠԡԢԣԤԥ                                            |
		| L1ÑÒÓÔÕÖ×ØÙÚÛÜÝÞß                                            | ÑÒÓÔÕÖ×ØÙÚÛÜÝÞß                                              |
		| L2àáâãäåæçèéêëìíîï                                           | àáâãäåæçèéêëìíîï                                             |
		| L3ðñòóôõö÷øùúûüýþÿĀ                                          | ðñòóôõö÷øùúûüýþÿĀ                                            |
		| L4āĂăĄąĆćĈĉĊċČčĎďĐđĒēĔĕ                                      | āĂăĄąĆćĈĉĊċČčĎďĐđĒēĔĕ                                        |
		| L5ĖėĘęĚěĜĝĞğĠġĢģĤĥ                                           | ĖėĘęĚěĜĝĞğĠġĢģĤĥ                                             |
		| L6ĦħĨĩĪīĬĭĮįİıĲĳĴĵĶķ                                         | ĦħĨĩĪīĬĭĮįİıĲĳĴĵĶķ                                           |
		| L7ĸĹĺĻļĽľĿŀŁłŃńŅņŇ                                           | ĸĹĺĻļĽľĿŀŁłŃńŅņŇ                                             |
		| L8ňŉŊŋŌōŎŏŐőŒœŔŕŖŗŘř                                         | ňŉŊŋŌōŎŏŐőŒœŔŕŖŗŘř                                           |
		| L9ŚśŜŝŞşŠšŢţŤťŦŧŨũŪūŬ                                        | ŚśŜŝŞşŠšŢţŤťŦŧŨũŪūŬ                                          |
		| L10ŭŮůŰűŲųŴŵŶŷŸŹźŻżŽž                                        | ŭŮůŰűŲųŴŵŶŷŸŹźŻżŽž                                           |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should register with any allowed company name
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with allowed company name <CompanyName>
		Then I should subscribe successfully
Examples:
		| CompanyName                              |
		| Testers Corp                             |
		| fourtyB54FA4F3CD444BA68AEAE0F0DCA197E04F |
		| 1 corp                                                       |
		| Test-                                                        |
		| Test.                                                        |
		| Test/                                                        |
		| Test+                                                        |
		| Test,                                                        |
		| Test:                                                        |
		| Test@                                                        |
		| Test?                                                        |
		| Test(                                                        |
		| Test)                                                        |
		| Test!                                                        |
		| Test'                                                        |
		| Test"                                                        |
		| Test&                                                        |
		| Test0123456789                                               |
		| qwertyuiopasdfghjklzxcvbnm                                   |
		| G1ͰͱͲͳʹ͵Ͷͷͺͻͼͽ;                                              |
		| G2B΄΅Ά·ΈΉΊΌΎΏΐΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟ                                |
		| G3CΠΡΣΤΥΦΧΨΩΪΫάέήίΰαβγδεζηθικλμνξο                           |
		| G4πρςστυφχψωϊϋόύώϏ                                           |
		| G5ϐϑϒϓϔϕϖϗϘϙϚϛϜϝϞϟ                                           |
		| G6ϠϡϢϣϤϥϦϧϨϩϪϫϬϭϮϯ                                           |
		| G7ϰϱϲϳϴϵ϶ϷϸϹϺϻϼϽϾϿ                                           |
		| R1ЀЁЂЃЄЅІЇЈЉЊЋЌЍЎЏАБВГД                                      |
		| R2ЕЖЗИЙКЛМНОПРСТУФХ                                          |
		| R3ЦЧШЩЪЫЬЭЮЯабвгде                                           |
		| R4жзийклмнопрстуфхцчшщъ                                      |
		| R5ыьэюяѐёђѓєѕіїјљњћќѝў                                       |
		| R6џѠѡѢѣѤѥѦѧѨѩѪѫѬѭ                                            |
		| R7ѮѯѰѱѲѳѴѵѶѷѸѹѺѻ                                             |
		| R8ѼѽѾѿҀҁ҂҃҄҅҆҇҈҉ҊҋҌҍҎҏ                                       |
		| R9ҐґҒғҔҕҖҗҘҙҚқҜҝҞҟ                                           |
		| R10ҠҡҢңҤҥҦҧҨҩҪ                                               |
		| R11ҫҬҭҮүҰұҲҳҴҵҶҷҸ                                            |
		| R12ҹҺһҼҽҾҿӀӁӂӃӄӅӆӇӈ                                          |
		| R13ӉӊӋӌӍӎӏӐӑӒӓӔӕӖӗӘә                                         |
		| R14ӚӛӜӝӞӟӠӡӢӣӤӥӦӧ                                            |
		| R15ӨөӪӫӬӭӮӯӰӱӲӳӴӵӶӷӸӹӺӻӼӽӾӿ                                  |
		| R16ԀԁԂԃԄԅԆԇԈԉԊԋԌԍԎԏԐԑԒԓԔԕԖ                                   |
		| R17ԗԘԙԚԛԜԝԞԟԠԡԢԣԤԥ                                         |
		| L1ÑÒÓÔÕÖ×ØÙÚÛÜÝÞß                                            |
		| L2àáâãäåæçèéêëìíîï                                           |
		| L3ðñòóôõö÷øùúûüýþÿĀ                                          |
		| L4āĂăĄąĆćĈĉĊċČčĎďĐđĒēĔĕ                                      |
		| L5ĖėĘęĚěĜĝĞğĠġĢģĤĥ                                           |
		| L6ĦħĨĩĪīĬĭĮįİıĲĳĴĵĶķ                                         |
		| L7ĸĹĺĻļĽľĿŀŁłŃńŅņŇ                                           |
		| L8ňŉŊŋŌōŎŏŐőŒœŔŕŖŗŘř                                         |
		| L9ŚśŜŝŞşŠšŢţŤťŦŧŨũŪūŬ                                        |
		| L10ŭŮůŰűŲųŴŵŶŷŸŹźŻżŽž                                        |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should register with any allowed adresses
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with allowed addresses <AddressOne> and <AddressTwo> and <AddressThree>
		Then I should subscribe successfully
Examples: 
		| AddressOne                                                   | AddressTwo                                                   | AddressThree                                                 |
		| Tester Street 5                                              | Some alley 3                                                 | Shady place  45                                              |
		| Test address                                                 | Some more                                                    |                                                              |
		| Test address                                                 |                                                              |                                                              |
		| qwertyuiopasdfghjklzxcvbnm                                   | qwertyuiopasdfghjklzxcvbnm                                   | qwertyuiopasdfghjklzxcvbnm                                   |
		| 0123456789                                                   | 0123456789                                                   | 0123456789                                                   |
		| sixty46C470FBA07993D61B46B54FA4F3CD444BA68AEAE0F0DCA197E04F6 | sixty46C470FBA07993D61B46B54FA4F3CD444BA68AEAE0F0DCA197E04F6 | sixty46C470FBA07993D61B46B54FA4F3CD444BA68AEAE0F0DCA197E04F6 |
		| First and third  122/33                                      |                                                              | Test                                                         |
		| Test address ! "                                             | Test address ! "                                             | Test address ! "                                             |
		| Test address #$%                                             | Test address #$%                                             | Test address #$%                                             |
		| Test address &'(                                             | Test address &'(                                             | Test address &'(                                             |
		| Test address )*+                                             | Test address )*+                                             | Test address )*+                                             |
		| Test address ,-.                                             | Test address ,-.                                             | Test address ,-.                                             |
		| Test address /:;                                             | Test address /:;                                             | Test address /:;                                             |
		| Test address =?@                                             | Test address =?@                                             | Test address =?@                                             |
		| Test address ^_~                                             | Test address ^_~                                             | Test address ^_~                                             |
		| All1ÂØĆŶǦʧΗϤУҦӘӂՆնפ                                              | ÂØĆŶǦʧΗϤУҦӘӂՆնפ                                              | ÂØĆŶǦʧΗϤУҦӘӂՆնפ                                              |
		| All2אطڅڼݕޙइ२ਘચಗಸനวดབႤ                                            | אطڅڼݕޙइ२ਘચಗಸനวดབႤ                                            | אطڅڼݕޙइ२ਘચಗಸനวดབႤ                                            |
		| All3ሥណᡵᥔẶ⿇ざㅦ㈱㌕㒃                                                  | ሥណᡵᥔẶ⿇ざㅦ㈱㌕㒃                                                  | ሥណᡵᥔẶ⿇ざㅦ㈱㌕㒃                                                  |
		| All4㒩㞖䃇䩗亓冕另寸懇柷                                                   | 㒩㞖䃇䩗亓冕另寸懇柷                                                   | 㒩㞖䃇䩗亓冕另寸懇柷                                                   |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should register with any allowed city
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with allowed city value <City>
		Then I should subscribe successfully
Examples:
		| City                                               |
		| Warsaw                                             |
		| 0123456789                                         |
		| fifty46C470FBA07993D61B46B54FA4F3CD444BA68AEAE0F0D |
		| City ! "                                           |
		| City #$%                                           |
		| City &'(                                           |
		| City )*+                                           |
		| City ,-.                                           |
		| City /:;                                           |
		| City =?@                                           |
		| City ^_~                                           |
		| All1ÂØĆŶǦʧΗϤУҦӘӂՆնפ                                |
		| All2אطڅڼݕޙइ२ਘચಗಸനวดབႤ                              |
		| All3ሥណᡵᥔẶ⿇ざㅦ㈱㌕㒃                                    |
		| All4㒩㞖䃇䩗亓冕另寸懇柷                                     |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should register with any allowed county
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with allowed county value <County>
		Then I should subscribe successfully
Examples:
		| County                                             |
		| Some county                                        |
		| 0123456789                                         |
		| fifty46C470FBA07993D61B46B54FA4F3CD444BA68AEAE0F0D |
		| County ! "                                         |
		| County #$%                                         |
		| County &'(                                         |
		| County )*+                                         |
		| County ,-.                                         |
		| County /:;                                         |
		| County =?@                                         |
		| County ^_~                                         |
		| All1ÂØĆŶǦʧΗϤУҦӘӂՆնפ                                |
		| All2אطڅڼݕޙइ२ਘચಗಸനวดབႤ                              |
		| All3ሥណᡵᥔẶ⿇ざㅦ㈱㌕㒃                                    |
		| All4㒩㞖䃇䩗亓冕另寸懇柷                                     |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should register with any allowed fax
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with allowed fax value <Fax>
		Then I should subscribe successfully
Examples:
		| Fax                                                |
		| 0123456789                                         |
		| fifty46C470FBA07993D61B46B54FA4F3CD444BA68AEAE0F0D |
		| Fax ! "                                            |
		| Fax #$%                                            |
		| Fax &'(                                            |
		| Fax )*+                                            |
		| Fax ,-.                                            |
		| Fax /:;                                            |
		| Fax =?@                                            |
		| Fax ^_~                                            |
		| All1ÂØĆŶǦʧΗϤУҦӘӂՆնפ                                |
		| All2אطڅڼݕޙइ२ਘચಗಸനวดབႤ                              |
		| All3ሥណᡵᥔẶ⿇ざㅦ㈱㌕㒃                                    |
		| All4㒩㞖䃇䩗亓冕另寸懇柷                                     |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should register with any allowed zip
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with allowed zip value <Zip>
		Then I should subscribe successfully
Examples:
		| Zip        |
		| 0123456789 |
		| ten0123456 |
		| Fax ! "                                            |
		| Fax #$%                                            |
		| Fax &'(                                            |
		| Fax )*+                                            |
		| Fax ,-.                                            |
		| Fax /:;                                            |
		| Fax =?@                                            |
		| Fax ^_~                                            |
		| All1ÂØĆŶǦʧΗϤУҦӘӂՆնפ                                |
		| All2אطڅڼݕޙइ२ਘચಗಸനวดབႤ                              |
		| All3ሥណᡵᥔẶ⿇ざㅦ㈱㌕㒃                                    |
		| All4㒩㞖䃇䩗亓冕另寸懇柷                                     |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should register with any allowed telephone number
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with allowed telephone number value <Telephone>
		Then I should subscribe successfully
Examples:
		| Telephone       |
		| 012345          |
		| 012345678901234 |
		| Test telepho #  |
		| Test telepho    |
		| Test telepho *  |
		| Test telepho (  |
		| Test telepho )  |
		| Test telepho -  |
		| Test telepho +  |
		| Test telepho ,  |
		| Test telepho .  |
		| 12-34-56        |
		| +48(32)123456   |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should not register when invalid first name entered
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with invalid first name <FirstName>
		Then I should stay at your details page
		And First name is invalid validation message should be displayed.
Examples:
		| FirstName                                                     |
		| 1ShouldFail                                                   |
		| #ShouldFail                                                   |
		| $ShouldFail                                                   |
		| sixtyOneABqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopA |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should not register when invalid surname entered
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with invalid surname <Surname>
		Then I should stay at your details page
		And Surname is invalid validation message should be displayed.
Examples:
		| Surname                                                       |
		| 1ShouldFail                                                   |
		| #ShouldFail                                                   |
		| $ShouldFail                                                   |
		| sixtyOneABqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopA |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should not register when invalid company name
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with invalid company name <CompanyName>
		Then I should stay at your details page
		And Company name is invalid validation message should be displayed.
Examples:
		| CompanyName                               |
		| fourtyOne0qwertyuiopqwertyuiopqwertyuiopA |
		| #ShouldFail                               |
		| &ShouldFail                               |
		| Should$Fail                               |
		
@tradefinancemagazine.com
Scenario Outline: Checkout - Should not register when invalid address one
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with invalid address one <AddressOne>
		Then I should stay at your details page
		And Address one is invalid validation message should be displayed.
Examples:
		| AddressOne                                                    |
		| sixtyOneABqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopA |
		
@tradefinancemagazine.com
Scenario Outline: Checkout - Should not register when invalid address two
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with invalid  address two <AddressTwo>
		Then I should stay at your details page
		And Address two is invalid validation message should be displayed.
Examples:
		| AddressTwo                                                    |
		| sixtyOneABqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopA |


@tradefinancemagazine.com
Scenario Outline: Checkout - Should not register when invalid address three
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with invalid address three <AddressThree>
		Then I should stay at your details page
		And Address three is invalid validation message should be displayed.
Examples:
		| AddressThree                                                  |
		| sixtyOneABqwertyuiopqwertyuiopqwertyuiopqwertyuiopqwertyuiopA |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should not register when invalid city
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with invalid city <City>
		Then I should stay at your details page
		And City is invalid validation message should be displayed.
Examples:
		| City                                                |
		| fiftyOneABqwertyuiopqwertyuiopqwertyuiopqwertyuiopA |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should not register when invalid county
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with invalid county <County>
		Then I should stay at your details page
		And County is invalid validation message should be displayed.
Examples:
		| County                                              |
		| fiftyOneABqwertyuiopqwertyuiopqwertyuiopqwertyuiopA |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should not register when invalid fax
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with invalid fax <Fax>
		Then I should stay at your details page
		And Fax is invalid validation message should be displayed.
Examples:
		| Fax                                                 |
		| fiftyOneABqwertyuiopqwertyuiopqwertyuiopqwertyuiopA |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should not register when invalid zip
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with invalid zip <Zip>
		Then I should stay at your details page
		And Zip is invalid validation message should be displayed.
Examples:
		| Zip         |
		| eleven01234 |

@tradefinancemagazine.com
Scenario Outline: Checkout - Should not register when invalid telephone
		Given Given I've selected basic subscription
		When I register with new email
		And I create a new accout with invalid telephone <Telephone>
		Then I should stay at your details page
		And Telephone is invalid validation message should be displayed.
Examples:
		| Telephone                 |
		| 01234                     |
		| 0123456789012345          |
		| String                    |
		| 02121!@$%^&_={}[]:;"'?/>< |