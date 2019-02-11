import os
import sys
from struct import unpack
print(sys.argv)
if not os.path.isfile(sys.argv[1]):
    sys.exit(0)

cia_file = open(sys.argv[1], 'r+b')
cia_header = cia_file.read(0x20)

# Find offset for tmd
cert_offset = 0x2040
cert_size = unpack('<I', cia_header[0x08:0x0C])[0]
tik_size = unpack('<I', cia_header[0x0C:0x10])[0]
tmd_size = unpack('<I', cia_header[0x10:0x14])[0]
tmd_offset = cert_offset + cert_size + 0x30 + tik_size
print(format(tmd_offset, '08x'))

# Read titleid from tmd
cia_file.seek(tmd_offset + 0x18C)
titleid = format(unpack('>Q', cia_file.read(0x8))[0], '016x')
print('TitleID|' + titleid + "|")

cia_file.close()