﻿namespace Model.Configuration.Seed;

/// <summary>
/// Entity seed
/// </summary>
internal sealed class CountrySeed : IEntityTypeConfiguration<Country>
{
    internal CountrySeed()
    {
    }

    public void Configure(EntityTypeBuilder<Country> builder) =>
        _ = builder.HasData(
            new Country(1, "Afghanistan", "AF", "AFG", 004, "https://upload.wikimedia.org/wikipedia/commons/5/5c/Flag_of_the_Taliban.svg"),
            new Country(2, "Albania", "AL", "ALB", 008, "https://upload.wikimedia.org/wikipedia/commons/3/36/Flag_of_Albania.svg"),
            new Country(3, "Alergia", "DZ", "DZA", 012, "https://upload.wikimedia.org/wikipedia/commons/7/77/Flag_of_Algeria.svg"),
            new Country(4, "Andorra", "AD", "AND", 020, "https://upload.wikimedia.org/wikipedia/commons/1/19/Flag_of_Andorra.svg"),
            new Country(5, "Angola", "AO", "AGO", 024, "https://upload.wikimedia.org/wikipedia/commons/9/9d/Flag_of_Angola.svg"),
            new Country(6, "Antigua and Barbuda", "AG", "ATG", 028, "https://upload.wikimedia.org/wikipedia/commons/8/89/Flag_of_Antigua_and_Barbuda.svg"),
            new Country(7, "Argentina", "AR", "ARG", 032, "https://upload.wikimedia.org/wikipedia/commons/1/1a/Flag_of_Argentina.svg"),
            new Country(8, "Armenia", "AM", "ARM", 051, "https://upload.wikimedia.org/wikipedia/commons/2/2f/Flag_of_Armenia.svg"),
            new Country(9, "Australia", "AU", "AUS", 036, "https://upload.wikimedia.org/wikipedia/commons/8/88/Flag_of_Australia_%28converted%29.svg"),
            new Country(10, "Austria", "AT", "AUT", 040, "https://upload.wikimedia.org/wikipedia/commons/4/41/Flag_of_Austria.svg"),
            new Country(11, "Azerbaijan", "AZ", "AZE", 031, "https://upload.wikimedia.org/wikipedia/commons/d/dd/Flag_of_Azerbaijan.svg"),
            new Country(12, "Bahamas", "BS", "BHS", 044, "https://upload.wikimedia.org/wikipedia/commons/9/93/Flag_of_the_Bahamas.svg"),
            new Country(13, "Bahrain", "BH", "BHR", 048, "https://upload.wikimedia.org/wikipedia/commons/2/2c/Flag_of_Bahrain.svg"),
            new Country(14, "Bangladesh", "BD", "BGD", 050, "https://upload.wikimedia.org/wikipedia/commons/f/f9/Flag_of_Bangladesh.svg"),
            new Country(15, "Barbados", "BB", "BRB", 052, "https://upload.wikimedia.org/wikipedia/commons/e/ef/Flag_of_Barbados.svg"),
            new Country(16, "Belarus", "BY", "BLR", 112, "https://upload.wikimedia.org/wikipedia/commons/8/85/Flag_of_Belarus.svg"),
            new Country(17, "Belgium", "BE", "BEL", 056, "https://upload.wikimedia.org/wikipedia/commons/6/65/Flag_of_Belgium.svg"),
            new Country(18, "Belize", "BZ", "BLZ", 084, "https://upload.wikimedia.org/wikipedia/commons/e/e7/Flag_of_Belize.svg"),
            new Country(19, "Benin", "BJ", "BEN", 204, "https://upload.wikimedia.org/wikipedia/commons/0/0a/Flag_of_Benin.svg"),
            new Country(20, "Bhutan", "BT", "BTN", 064, "https://upload.wikimedia.org/wikipedia/commons/9/91/Flag_of_Bhutan.svg"),
            new Country(21, "Bolivia", "BO", "BOL", 068, "https://upload.wikimedia.org/wikipedia/commons/d/de/Flag_of_Bolivia_%28state%29.svg"),
            new Country(22, "Bosnia and Herzegovina", "BA", "BIH", 070, "https://upload.wikimedia.org/wikipedia/commons/b/bf/Flag_of_Bosnia_and_Herzegovina.svg"),
            new Country(23, "Botswana", "BW", "BWA", 072, "https://upload.wikimedia.org/wikipedia/commons/f/fa/Flag_of_Botswana.svg"),
            new Country(24, "Brazil", "BR", "BRA", 076, "https://upload.wikimedia.org/wikipedia/en/0/05/Flag_of_Brazil.svg"),
            new Country(25, "Brunei Darussalam", "BN", "BRN", 096, "https://upload.wikimedia.org/wikipedia/commons/9/9c/Flag_of_Brunei.svg"),
            new Country(26, "Bulgaria", "BG", "BGR", 100, "https://upload.wikimedia.org/wikipedia/commons/9/9a/Flag_of_Bulgaria.svg"),
            new Country(27, "Burkina Faso", "BF", "BFA", 854, "https://upload.wikimedia.org/wikipedia/commons/3/31/Flag_of_Burkina_Faso.svg"),
            new Country(28, "Burundi", "BI", "BDI", 108, "https://upload.wikimedia.org/wikipedia/commons/5/50/Flag_of_Burundi.svg"),
            new Country(29, "Cabo Verde", "CV", "CPV", 132, "https://upload.wikimedia.org/wikipedia/commons/3/38/Flag_of_Cape_Verde.svg"),
            new Country(30, "Cambodia", "KH", "KHM", 116, "https://upload.wikimedia.org/wikipedia/commons/8/83/Flag_of_Cambodia.svg"),
            new Country(31, "Cameroon", "CM", "CMR", 120, "https://upload.wikimedia.org/wikipedia/commons/4/4f/Flag_of_Cameroon.svg"),
            new Country(32, "Canada", "CA", "CAN", 124, "https://upload.wikimedia.org/wikipedia/commons/d/d9/Flag_of_Canada_%28Pantone%29.svg"),
            new Country(33, "Central African Republic", "CF", "CAF", 140, "https://upload.wikimedia.org/wikipedia/commons/6/6f/Flag_of_the_Central_African_Republic.svg"),
            new Country(34, "Chad", "TD", "TCD", 148, "https://upload.wikimedia.org/wikipedia/commons/4/4b/Flag_of_Chad.svg"),
            new Country(35, "Chile", "CL", "CHL", 152, "https://upload.wikimedia.org/wikipedia/commons/7/78/Flag_of_Chile.svg"),
            new Country(36, "China", "CN", "CHN", 156, "https://upload.wikimedia.org/wikipedia/commons/f/fa/Flag_of_the_People%27s_Republic_of_China.svg"),
            new Country(37, "Colombia", "CO", "COL", 170, "https://upload.wikimedia.org/wikipedia/commons/2/21/Flag_of_Colombia.svg"),
            new Country(38, "Comoros", "KM", "COM", 174, "https://upload.wikimedia.org/wikipedia/commons/9/94/Flag_of_the_Comoros.svg"),
            new Country(39, "Congo", "CG", "COG", 178, "https://upload.wikimedia.org/wikipedia/commons/9/92/Flag_of_the_Republic_of_the_Congo.svg"),
            new Country(40, "Democratic Republic of the Congo", "CD", "COD", 180, "https://upload.wikimedia.org/wikipedia/commons/6/6f/Flag_of_the_Democratic_Republic_of_the_Congo.svg"),
            new Country(41, "Costa Rica", "CR", "CRI", 188, "https://upload.wikimedia.org/wikipedia/commons/b/bc/Flag_of_Costa_Rica_%28state%29.svg"),
            new Country(42, "Cote d'Ivoire", "CI", "CIV", 384, "https://upload.wikimedia.org/wikipedia/commons/f/fe/Flag_of_C%C3%B4te_d%27Ivoire.svg"),
            new Country(43, "Croatia", "HR", "HRV", 191, "https://upload.wikimedia.org/wikipedia/commons/1/1b/Flag_of_Croatia.svg"),
            new Country(44, "Cuba", "CU", "CUB", 192, "https://upload.wikimedia.org/wikipedia/commons/b/bd/Flag_of_Cuba.svg"),
            new Country(45, "Cyprus", "CY", "CYP", 196, "https://upload.wikimedia.org/wikipedia/commons/d/d4/Flag_of_Cyprus.svg"),
            new Country(46, "Czechia", "CZ", "CZE", 203, "https://upload.wikimedia.org/wikipedia/commons/c/cb/Flag_of_the_Czech_Republic.svg"),
            new Country(47, "Denmark", "DK", "DNK", 208, "https://upload.wikimedia.org/wikipedia/commons/9/9c/Flag_of_Denmark.svg"),
            new Country(48, "Djibouti", "DJ", "DJI", 262, "https://upload.wikimedia.org/wikipedia/commons/3/34/Flag_of_Djibouti.svg"),
            new Country(49, "Dominica", "DM", "DMA", 212, "https://upload.wikimedia.org/wikipedia/commons/c/c4/Flag_of_Dominica.svg"),
            new Country(50, "Dominican Republic", "DO", "DOM", 214, "https://upload.wikimedia.org/wikipedia/commons/9/9f/Flag_of_the_Dominican_Republic.svg"),
            new Country(51, "Ecuador", "EC", "ECU", 218, "https://upload.wikimedia.org/wikipedia/commons/e/e8/Flag_of_Ecuador.svg"),
            new Country(52, "Egypt", "EG", "EGY", 818, "https://upload.wikimedia.org/wikipedia/commons/f/fe/Flag_of_Egypt.svg"),
            new Country(53, "El Salvador", "SV", "SLV", 222, "https://upload.wikimedia.org/wikipedia/commons/3/34/Flag_of_El_Salvador.svg"),
            new Country(54, "Equatorial Guinea", "GQ", "GNQ", 226, "https://upload.wikimedia.org/wikipedia/commons/3/31/Flag_of_Equatorial_Guinea.svg"),
            new Country(55, "Eritrea", "ER", "ERI", 232, "https://upload.wikimedia.org/wikipedia/commons/2/29/Flag_of_Eritrea.svg"),
            new Country(56, "Estonia", "EE", "EST", 233, "https://upload.wikimedia.org/wikipedia/commons/8/8f/Flag_of_Estonia.svg"),
            new Country(57, "Eswatini", "SZ", "SWZ", 748, "https://upload.wikimedia.org/wikipedia/commons/f/fb/Flag_of_Eswatini.svg"),
            new Country(58, "Ethiopia", "ET", "ETH", 231, "https://upload.wikimedia.org/wikipedia/commons/7/71/Flag_of_Ethiopia.svg"),
            new Country(59, "Fiji", "FJ", "FJI", 242, "https://upload.wikimedia.org/wikipedia/commons/b/ba/Flag_of_Fiji.svg"),
            new Country(60, "Finland", "FI", "FIN", 246, "https://upload.wikimedia.org/wikipedia/commons/b/bc/Flag_of_Finland.svg"),
            new Country(61, "France", "FR", "FRA", 250, "https://upload.wikimedia.org/wikipedia/commons/b/bc/Flag_of_France_%281794%E2%80%931815%2C_1830%E2%80%931974%2C_2020%E2%80%93present%29.svg"),
            new Country(62, "Gabon", "GA", "GAB", 266, "https://upload.wikimedia.org/wikipedia/commons/0/04/Flag_of_Gabon.svg"),
            new Country(63, "Gambia", "GM", "GMB", 270, "https://upload.wikimedia.org/wikipedia/commons/7/77/Flag_of_The_Gambia.svg"),
            new Country(64, "Georgia", "GE", "GEO", 268, "https://upload.wikimedia.org/wikipedia/commons/0/0f/Flag_of_Georgia.svg"),
            new Country(65, "Germany", "DE", "DEU", 276, "https://upload.wikimedia.org/wikipedia/en/b/ba/Flag_of_Germany.svg"),
            new Country(66, "Ghana", "GH", "GHA", 288, "https://upload.wikimedia.org/wikipedia/commons/1/19/Flag_of_Ghana.svg"),
            new Country(67, "Greece", "GR", "GRC", 300, "https://upload.wikimedia.org/wikipedia/commons/5/5c/Flag_of_Greece.svg"),
            new Country(68, "Grenada", "GD", "GRD", 308, "https://upload.wikimedia.org/wikipedia/commons/b/bc/Flag_of_Grenada.svg"),
            new Country(69, "Guatemala", "GT", "GTM", 320, "https://upload.wikimedia.org/wikipedia/commons/e/ec/Flag_of_Guatemala.svg"),
            new Country(70, "Guinea", "GN", "GIN", 324, "https://upload.wikimedia.org/wikipedia/commons/e/ed/Flag_of_Guinea.svg"),
            new Country(71, "Guinea-Bissau", "GW", "GNB", 624, "https://upload.wikimedia.org/wikipedia/commons/0/01/Flag_of_Guinea-Bissau.svg"),
            new Country(72, "Guyana", "GY", "GUY", 328, "https://upload.wikimedia.org/wikipedia/commons/9/99/Flag_of_Guyana.svg"),
            new Country(73, "Haiti", "HT", "HTI", 332, "https://upload.wikimedia.org/wikipedia/commons/5/56/Flag_of_Haiti.svg"),
            new Country(74, "Holy See", "VA", "VAT", 336, "https://upload.wikimedia.org/wikipedia/commons/0/00/Flag_of_the_Vatican_City.svg"),
            new Country(75, "Honduras", "HN", "HND", 340, "https://upload.wikimedia.org/wikipedia/commons/1/17/Flag_of_Honduras_used_by_the_UNAH.svg"),
            new Country(76, "Hungary", "HU", "HUN", 348, "https://upload.wikimedia.org/wikipedia/commons/c/c1/Flag_of_Hungary.svg"),
            new Country(77, "Iceland", "IS", "ISL", 352, "https://upload.wikimedia.org/wikipedia/commons/c/ce/Flag_of_Iceland.svg"),
            new Country(78, "India", "IN", "IND", 356, "https://upload.wikimedia.org/wikipedia/en/4/41/Flag_of_India.svg"),
            new Country(79, "Indonesia", "ID", "IDN", 360, "https://upload.wikimedia.org/wikipedia/commons/9/9f/Flag_of_Indonesia.svg"),
            new Country(80, "Iran", "IR", "IRN", 364, "https://upload.wikimedia.org/wikipedia/commons/c/ca/Flag_of_Iran.svg"),
            new Country(81, "Iraq", "IQ", "IRQ", 368, "https://upload.wikimedia.org/wikipedia/commons/f/f6/Flag_of_Iraq.svg"),
            new Country(82, "Ireland", "IE", "IRL", 372, "https://upload.wikimedia.org/wikipedia/commons/4/45/Flag_of_Ireland.svg"),
            new Country(83, "Israel", "IL", "ISR", 376, "https://upload.wikimedia.org/wikipedia/commons/d/d4/Flag_of_Israel.svg"),
            new Country(84, "Italy", "IT", "ITA", 380, "https://upload.wikimedia.org/wikipedia/en/0/03/Flag_of_Italy.svg"),
            new Country(85, "Jamaica", "JM", "JAM", 388, "https://upload.wikimedia.org/wikipedia/commons/0/0a/Flag_of_Jamaica.svg"),
            new Country(86, "Japan", "JP", "JPN", 392, "https://upload.wikimedia.org/wikipedia/en/9/9e/Flag_of_Japan.svg"),
            new Country(87, "Jordan", "JO", "JOR", 400, "https://upload.wikimedia.org/wikipedia/commons/c/c0/Flag_of_Jordan.svg"),
            new Country(88, "Kazakhstan", "KZ", "KAZ", 398, "https://upload.wikimedia.org/wikipedia/commons/d/d3/Flag_of_Kazakhstan.svg"),
            new Country(89, "Kenya", "KE", "KEN", 404, "https://upload.wikimedia.org/wikipedia/commons/4/49/Flag_of_Kenya.svg"),
            new Country(90, "Kiribati", "KI", "KIR", 296, "https://upload.wikimedia.org/wikipedia/commons/d/d3/Flag_of_Kiribati.svg"),
            new Country(91, "North Korea", "KP", "PRK", 408, "https://upload.wikimedia.org/wikipedia/commons/5/51/Flag_of_North_Korea.svg"),
            new Country(92, "South Korea", "KR", "KOR", 410, "https://upload.wikimedia.org/wikipedia/commons/0/09/Flag_of_South_Korea.svg"),
            new Country(93, "Kuwait", "KW", "KWT", 414, "https://upload.wikimedia.org/wikipedia/commons/a/aa/Flag_of_Kuwait.svg"),
            new Country(94, "Kyrgyzstan", "KG", "KGZ", 417, "https://upload.wikimedia.org/wikipedia/commons/c/c7/Flag_of_Kyrgyzstan.svg"),
            new Country(95, "Laos", "LA", "LAO", 418, "https://upload.wikimedia.org/wikipedia/commons/5/56/Flag_of_Laos.svg"),
            new Country(96, "Latvia", "LV", "LVA", 428, "https://upload.wikimedia.org/wikipedia/commons/8/84/Flag_of_Latvia.svg"),
            new Country(97, "Lebanon", "LB", "LBN", 422, "https://upload.wikimedia.org/wikipedia/commons/5/59/Flag_of_Lebanon.svg"),
            new Country(98, "Lesotho", "LS", "LSO", 426, "https://upload.wikimedia.org/wikipedia/commons/4/4a/Flag_of_Lesotho.svg"),
            new Country(99, "Liberia", "LR", "LBR", 430, "https://upload.wikimedia.org/wikipedia/commons/b/b8/Flag_of_Liberia.svg"),
            new Country(100, "Libya", "LY", "LBY", 434, "https://upload.wikimedia.org/wikipedia/commons/0/05/Flag_of_Libya.svg"),
            new Country(101, "Liechtenstein", "LI", "LIE", 438, "https://upload.wikimedia.org/wikipedia/commons/4/47/Flag_of_Liechtenstein.svg"),
            new Country(102, "Lithuania", "LT", "LTU", 440, "https://upload.wikimedia.org/wikipedia/commons/1/11/Flag_of_Lithuania.svg"),
            new Country(103, "Luxembourg", "LU", "LUX", 442, "https://upload.wikimedia.org/wikipedia/commons/d/da/Flag_of_Luxembourg.svg"),
            new Country(104, "Madagascar", "MG", "MDG", 450, "https://upload.wikimedia.org/wikipedia/commons/b/bc/Flag_of_Madagascar.svg"),
            new Country(105, "Malawi", "MW", "MWI", 454, "https://upload.wikimedia.org/wikipedia/commons/d/d1/Flag_of_Malawi.svg"),
            new Country(106, "Malaysia", "MY", "MYS", 458, "https://upload.wikimedia.org/wikipedia/commons/6/66/Flag_of_Malaysia.svg"),
            new Country(107, "Maldives", "MV", "MDV", 462, "https://upload.wikimedia.org/wikipedia/commons/0/0f/Flag_of_Maldives.svg"),
            new Country(108, "Mali", "ML", "MLI", 466, "https://upload.wikimedia.org/wikipedia/commons/9/92/Flag_of_Mali.svg"),
            new Country(109, "Malta", "MT", "MLT", 470, "https://upload.wikimedia.org/wikipedia/commons/7/73/Flag_of_Malta.svg"),
            new Country(110, "Marshall Islands", "MH", "MHL", 584, "https://upload.wikimedia.org/wikipedia/commons/2/2e/Flag_of_the_Marshall_Islands.svg"),
            new Country(111, "Mauritania", "MR", "MRT", 478, "https://upload.wikimedia.org/wikipedia/commons/4/43/Flag_of_Mauritania.svg"),
            new Country(112, "Mauritius", "MU", "MUS", 480, "https://upload.wikimedia.org/wikipedia/commons/7/77/Flag_of_Mauritius.svg"),
            new Country(113, "Mexico", "MX", "MEX", 484, "https://upload.wikimedia.org/wikipedia/commons/f/fc/Flag_of_Mexico.svg"),
            new Country(114, "Micronesia", "FM", "FSM", 583, "https://upload.wikimedia.org/wikipedia/commons/e/e4/Flag_of_the_Federated_States_of_Micronesia.svg"),
            new Country(115, "Moldova", "MD", "MDA", 498, "https://upload.wikimedia.org/wikipedia/commons/2/27/Flag_of_Moldova.svg"),
            new Country(116, "Monaco", "MC", "MCO", 492, "https://upload.wikimedia.org/wikipedia/commons/e/ea/Flag_of_Monaco.svg"),
            new Country(117, "Mongolia", "MN", "MNG", 496, "https://upload.wikimedia.org/wikipedia/commons/4/4c/Flag_of_Mongolia.svg"),
            new Country(118, "Montenegro", "ME", "MNE", 499, "https://upload.wikimedia.org/wikipedia/commons/6/64/Flag_of_Montenegro.svg"),
            new Country(119, "Morocco", "MA", "MAR", 504, "https://upload.wikimedia.org/wikipedia/commons/2/2c/Flag_of_Morocco.svg"),
            new Country(120, "Mozambique", "MZ", "MOZ", 508, "https://upload.wikimedia.org/wikipedia/commons/d/d0/Flag_of_Mozambique.svg"),
            new Country(121, "Myanmar", "MM", "MMR", 104, "https://upload.wikimedia.org/wikipedia/commons/8/8c/Flag_of_Myanmar.svg"),
            new Country(122, "Namibia", "NA", "NAM", 516, "https://upload.wikimedia.org/wikipedia/commons/0/00/Flag_of_Namibia.svg"),
            new Country(123, "Nauru", "NR", "NRU", 520, "https://upload.wikimedia.org/wikipedia/commons/3/30/Flag_of_Nauru.svg"),
            new Country(124, "Nepal", "NP", "NPL", 524, "https://upload.wikimedia.org/wikipedia/commons/9/9b/Flag_of_Nepal.svg"),
            new Country(125, "Netherlands", "NL", "NLD", 528, "https://upload.wikimedia.org/wikipedia/commons/2/20/Flag_of_the_Netherlands.svg"),
            new Country(126, "New Zealand", "NZ", "NZL", 554, "https://upload.wikimedia.org/wikipedia/commons/3/3e/Flag_of_New_Zealand.svg"),
            new Country(127, "Nicaragua", "NI", "NIC", 558, "https://upload.wikimedia.org/wikipedia/commons/1/19/Flag_of_Nicaragua.svg"),
            new Country(128, "Niger", "NE", "NER", 562, "https://upload.wikimedia.org/wikipedia/commons/f/f4/Flag_of_Niger.svg"),
            new Country(129, "Nigeria", "NG", "NGA", 566, "https://upload.wikimedia.org/wikipedia/commons/7/79/Flag_of_Nigeria.svg"),
            new Country(130, "North Macedonia", "MK", "MKD", 807, "https://upload.wikimedia.org/wikipedia/commons/7/79/Flag_of_North_Macedonia.svg"),
            new Country(131, "Norway", "NO", "NOR", 578, "https://upload.wikimedia.org/wikipedia/commons/d/d9/Flag_of_Norway.svg"),
            new Country(132, "Oman", "OM", "OMN", 512, "https://upload.wikimedia.org/wikipedia/commons/d/dd/Flag_of_Oman.svg"),
            new Country(133, "Pakistan", "PK", "PAK", 586, "https://upload.wikimedia.org/wikipedia/commons/3/32/Flag_of_Pakistan.svg"),
            new Country(134, "Palau", "PW", "PLW", 585, "https://upload.wikimedia.org/wikipedia/commons/4/48/Flag_of_Palau.svg"),
            new Country(135, "Panama", "PA", "PAN", 591, "https://upload.wikimedia.org/wikipedia/commons/a/ab/Flag_of_Panama.svg"),
            new Country(136, "Papua New Guinea", "PG", "PNG", 598, "https://upload.wikimedia.org/wikipedia/commons/e/e3/Flag_of_Papua_New_Guinea.svg"),
            new Country(137, "Paraguay", "PY", "PRY", 600, "https://uhttps://upload.wikimedia.org/wikipedia/commons/c/cf/Flag_of_Peru.svgpload.wikimedia.org/wikipedia/commons/2/27/Flag_of_Paraguay.svg"),
            new Country(138, "Peru", "PE", "PER", 604, "https://upload.wikimedia.org/wikipedia/commons/c/cf/Flag_of_Peru.svg"),
            new Country(139, "Philippines", "PH", "PHL", 608, "https://upload.wikimedia.org/wikipedia/commons/9/99/Flag_of_the_Philippines.svg"),
            new Country(140, "Poland", "PL", "POL", 616, "https://upload.wikimedia.org/wikipedia/en/1/12/Flag_of_Poland.svg"),
            new Country(141, "Portugal", "PT", "PRT", 620, "https://upload.wikimedia.org/wikipedia/commons/5/5c/Flag_of_Portugal.svg"),
            new Country(142, "Qatar", "QA", "QAT", 634, "https://upload.wikimedia.org/wikipedia/commons/6/65/Flag_of_Qatar.svg"),
            new Country(143, "Romania", "RO", "ROU", 642, "https://upload.wikimedia.org/wikipedia/commons/7/73/Flag_of_Romania.svg"),
            new Country(144, "Russia", "RU", "RUS", 643, "https://upload.wikimedia.org/wikipedia/en/f/f3/Flag_of_Russia.svg"),
            new Country(145, "Rwanda", "RW", "RWA", 646, "https://upload.wikimedia.org/wikipedia/commons/1/17/Flag_of_Rwanda.svg"),
            new Country(146, "Saint Kitts and Nevis", "KN", "KNA", 659, "https://upload.wikimedia.org/wikipedia/commons/f/fe/Flag_of_Saint_Kitts_and_Nevis.svg"),
            new Country(147, "Saint Lucia", "LC", "LCA", 662, "https://upload.wikimedia.org/wikipedia/commons/9/9f/Flag_of_Saint_Lucia.svg"),
            new Country(148, "Saint Vincent and the Grenadines", "VC", "VCT", 670, "https://upload.wikimedia.org/wikipedia/commons/6/6d/Flag_of_Saint_Vincent_and_the_Grenadines.svg"),
            new Country(149, "Samoa", "WS", "WSM", 882, "https://upload.wikimedia.org/wikipedia/commons/3/31/Flag_of_Samoa.svg"),
            new Country(150, "San Marino", "SM", "SMR", 674, "https://upload.wikimedia.org/wikipedia/commons/b/b1/Flag_of_San_Marino.svg"),
            new Country(151, "Sao Tome and Principe", "ST", "STP", 678, "https://upload.wikimedia.org/wikipedia/commons/4/4f/Flag_of_Sao_Tome_and_Principe.svg"),
            new Country(152, "Saudi Arabia", "SA", "SAU", 682, "https://upload.wikimedia.org/wikipedia/commons/0/0d/Flag_of_Saudi_Arabia.svg"),
            new Country(153, "Senegal", "SN", "SEN", 686, "https://upload.wikimedia.org/wikipedia/commons/f/fd/Flag_of_Senegal.svg"),
            new Country(154, "Serbia", "RS", "SRB", 688, "https://upload.wikimedia.org/wikipedia/commons/f/ff/Flag_of_Serbia.svg"),
            new Country(155, "Seychelles", "SC", "SYC", 690, "https://upload.wikimedia.org/wikipedia/commons/f/fc/Flag_of_Seychelles.svg"),
            new Country(156, "Sierra Leone", "SL", "SLE", 694, "https://upload.wikimedia.org/wikipedia/commons/1/17/Flag_of_Sierra_Leone.svg"),
            new Country(157, "Singapore", "SG", "SGP", 702, "https://upload.wikimedia.org/wikipedia/commons/4/48/Flag_of_Singapore.svg"),
            new Country(158, "Slovakia", "SK", "SVK", 703, "https://upload.wikimedia.org/wikipedia/commons/e/e6/Flag_of_Slovakia.svg"),
            new Country(159, "Slovenia", "SI", "SVN", 705, "https://upload.wikimedia.org/wikipedia/commons/f/f0/Flag_of_Slovenia.svg"),
            new Country(160, "Solomon Islands", "SB", "SLB", 090, "https://upload.wikimedia.org/wikipedia/commons/7/74/Flag_of_the_Solomon_Islands.svg"),
            new Country(161, "Somalia", "SO", "SOM", 706, "https://upload.wikimedia.org/wikipedia/commons/a/a0/Flag_of_Somalia.svg"),
            new Country(162, "South Africa", "ZA", "ZAF", 710, "https://upload.wikimedia.org/wikipedia/commons/a/af/Flag_of_South_Africa.svg"),
            new Country(163, "South Sudan", "SS", "SSD", 728, "https://upload.wikimedia.org/wikipedia/commons/7/7a/Flag_of_South_Sudan.svg"),
            new Country(164, "Spain", "ES", "ESP", 724, "https://upload.wikimedia.org/wikipedia/commons/8/89/Bandera_de_Espa%C3%B1a.svg"),
            new Country(165, "Sri Lanka", "LK", "LKA", 144, "https://upload.wikimedia.org/wikipedia/commons/1/11/Flag_of_Sri_Lanka.svg"),
            new Country(166, "Sudan", "SD", "SDN", 729, "https://upload.wikimedia.org/wikipedia/commons/0/01/Flag_of_Sudan.svg"),
            new Country(167, "Suriname", "SR", "SUR", 740, "https://upload.wikimedia.org/wikipedia/commons/6/60/Flag_of_Suriname.svg"),
            new Country(168, "Sweden", "SE", "SWE", 752, "https://upload.wikimedia.org/wikipedia/en/4/4c/Flag_of_Sweden.svg"),
            new Country(169, "Switzerland", "CH", "CHE", 756, "https://upload.wikimedia.org/wikipedia/commons/f/f3/Flag_of_Switzerland.svg"),
            new Country(170, "Syrian", "SY", "SYR", 760, "https://upload.wikimedia.org/wikipedia/commons/5/53/Flag_of_Syria.svg"),
            new Country(171, "Tajikistan", "TJ", "TJK", 762, "https://upload.wikimedia.org/wikipedia/commons/d/d0/Flag_of_Tajikistan.svg"),
            new Country(172, "Tanzania", "TZ", "TZA", 834, "https://upload.wikimedia.org/wikipedia/commons/3/38/Flag_of_Tanzania.svg"),
            new Country(173, "Thailand", "TH", "THA", 764, "https://upload.wikimedia.org/wikipedia/commons/a/a9/Flag_of_Thailand.svg"),
            new Country(174, "Timor-Leste", "TL", "TLS", 626, "https://upload.wikimedia.org/wikipedia/commons/2/26/Flag_of_East_Timor.svg"),
            new Country(175, "Togo", "TG", "TGO", 768, "https://upload.wikimedia.org/wikipedia/commons/6/68/Flag_of_Togo.svg"),
            new Country(176, "Tonga", "TO", "TON", 776, "https://upload.wikimedia.org/wikipedia/commons/9/9a/Flag_of_Tonga.svg"),
            new Country(177, "Trinidad and Tobago", "TT", "TTO", 780, "https://upload.wikimedia.org/wikipedia/commons/6/64/Flag_of_Trinidad_and_Tobago.svg"),
            new Country(178, "Tunisia", "TN", "TUN", 788, "https://upload.wikimedia.org/wikipedia/commons/c/ce/Flag_of_Tunisia.svg"),
            new Country(179, "Turkey", "TR", "TUR", 792, "https://upload.wikimedia.org/wikipedia/commons/b/b4/Flag_of_Turkey.svg"),
            new Country(180, "Turkmenistan", "TM", "TKM", 795, "https://upload.wikimedia.org/wikipedia/commons/1/1b/Flag_of_Turkmenistan.svg"),
            new Country(181, "Tuvalu", "TV", "TUV", 798, "https://upload.wikimedia.org/wikipedia/commons/3/38/Flag_of_Tuvalu.svg"),
            new Country(182, "Uganda", "UG", "UGA", 800, "https://upload.wikimedia.org/wikipedia/commons/4/4e/Flag_of_Uganda.svg"),
            new Country(183, "Ukraine", "UA", "UKR", 804, "https://upload.wikimedia.org/wikipedia/commons/4/49/Flag_of_Ukraine.svg"),
            new Country(184, "United Arab Emirates", "AE", "ARE", 784, "https://upload.wikimedia.org/wikipedia/commons/c/cb/Flag_of_the_United_Arab_Emirates.svg"),
            new Country(185, "United Kingdom of Great Britain and Northern Ireland", "GB", "GBR", 826, "https://upload.wikimedia.org/wikipedia/en/a/ae/Flag_of_the_United_Kingdom.svg"),
            new Country(186, "United States of America", "US", "USA", 840, "https://upload.wikimedia.org/wikipedia/en/a/a4/Flag_of_the_United_States.svg"),
            new Country(187, "Uruguay", "UY", "URY", 858, "https://upload.wikimedia.org/wikipedia/commons/f/fe/Flag_of_Uruguay.svg"),
            new Country(188, "Uzbekistan", "UZ", "UZB", 860, "https://upload.wikimedia.org/wikipedia/commons/8/84/Flag_of_Uzbekistan.svg"),
            new Country(189, "Vanuatu", "VU", "VUT", 548, "https://upload.wikimedia.org/wikipedia/commons/6/6e/Flag_of_Vanuatu_%28official%29.svg"),
            new Country(190, "Venezuela", "VE", "VEN", 862, "https://upload.wikimedia.org/wikipedia/commons/0/06/Flag_of_Venezuela.svg"),
            new Country(191, "Vietnam", "VN", "VNM", 704, "https://upload.wikimedia.org/wikipedia/commons/2/21/Flag_of_Vietnam.svg"),
            new Country(192, "Yemen", "YE", "YEM", 887, "https://upload.wikimedia.org/wikipedia/commons/8/89/Flag_of_Yemen.svg"),
            new Country(193, "Zambia", "ZM", "ZMB", 894, "https://upload.wikimedia.org/wikipedia/commons/0/06/Flag_of_Zambia.svg"),
            new Country(194, "Zimbabwe", "ZW", "ZWE", 716, "https://upload.wikimedia.org/wikipedia/commons/6/6a/Flag_of_Zimbabwe.svg")
            );
}