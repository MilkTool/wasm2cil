// this file is automatically generated
module wasm.write_instr
    open wasm.instr
    open wasm.write_basic
    open wasm.write_args
    let write_instruction (w: System.IO.BinaryWriter) op =
        match op with
        | Unreachable ->
            write_byte w 0x00uy
        | Nop ->
            write_byte w 0x01uy
        | Block i ->
            write_byte w 0x02uy
            write_byte w i
        | Loop i ->
            write_byte w 0x03uy
            write_byte w i
        | If i ->
            write_byte w 0x04uy
            write_byte w i
        | Else ->
            write_byte w 0x05uy
        | End ->
            write_byte w 0x0buy
        | Br i ->
            write_byte w 0x0cuy
            write_var_u32 w i
        | BrIf i ->
            write_byte w 0x0duy
            write_var_u32 w i
        | BrTable i ->
            write_byte w 0x0euy
            write_brtable w i
        | Return ->
            write_byte w 0x0fuy
        | Call i ->
            write_byte w 0x10uy
            write_var_u32 w i
        | CallIndirect i ->
            write_byte w 0x11uy
            write_callindirect w i
        | Drop ->
            write_byte w 0x1auy
        | Select ->
            write_byte w 0x1buy
        | LocalGet i ->
            write_byte w 0x20uy
            write_var_u32 w i
        | LocalSet i ->
            write_byte w 0x21uy
            write_var_u32 w i
        | LocalTee i ->
            write_byte w 0x22uy
            write_var_u32 w i
        | GlobalGet i ->
            write_byte w 0x23uy
            write_var_u32 w i
        | GlobalSet i ->
            write_byte w 0x24uy
            write_var_u32 w i
        | I32Load i ->
            write_byte w 0x28uy
            write_memarg w i
        | I64Load i ->
            write_byte w 0x29uy
            write_memarg w i
        | F32Load i ->
            write_byte w 0x2auy
            write_memarg w i
        | F64Load i ->
            write_byte w 0x2buy
            write_memarg w i
        | I32Load8S i ->
            write_byte w 0x2cuy
            write_memarg w i
        | I32Load8U i ->
            write_byte w 0x2duy
            write_memarg w i
        | I32Load16S i ->
            write_byte w 0x2euy
            write_memarg w i
        | I32Load16U i ->
            write_byte w 0x2fuy
            write_memarg w i
        | I64Load8S i ->
            write_byte w 0x30uy
            write_memarg w i
        | I64Load8U i ->
            write_byte w 0x31uy
            write_memarg w i
        | I64Load16S i ->
            write_byte w 0x32uy
            write_memarg w i
        | I64Load16U i ->
            write_byte w 0x33uy
            write_memarg w i
        | I64Load32S i ->
            write_byte w 0x34uy
            write_memarg w i
        | I64Load32U i ->
            write_byte w 0x35uy
            write_memarg w i
        | I32Store i ->
            write_byte w 0x36uy
            write_memarg w i
        | I64Store i ->
            write_byte w 0x37uy
            write_memarg w i
        | F32Store i ->
            write_byte w 0x38uy
            write_memarg w i
        | F64Store i ->
            write_byte w 0x39uy
            write_memarg w i
        | I32Store8 i ->
            write_byte w 0x3auy
            write_memarg w i
        | I32Store16 i ->
            write_byte w 0x3buy
            write_memarg w i
        | I64Store8 i ->
            write_byte w 0x3cuy
            write_memarg w i
        | I64Store16 i ->
            write_byte w 0x3duy
            write_memarg w i
        | I64Store32 i ->
            write_byte w 0x3euy
            write_memarg w i
        | MemorySize i ->
            write_byte w 0x3fuy
            write_byte w i
        | MemoryGrow i ->
            write_byte w 0x40uy
            write_byte w i
        | I32Const i ->
            write_byte w 0x41uy
            write_var_i32 w i
        | I64Const i ->
            write_byte w 0x42uy
            write_var_i64 w i
        | F32Const i ->
            write_byte w 0x43uy
            write_f32 w i
        | F64Const i ->
            write_byte w 0x44uy
            write_f64 w i
        | I32Eqz ->
            write_byte w 0x45uy
        | I32Eq ->
            write_byte w 0x46uy
        | I32Ne ->
            write_byte w 0x47uy
        | I32LtS ->
            write_byte w 0x48uy
        | I32LtU ->
            write_byte w 0x49uy
        | I32GtS ->
            write_byte w 0x4auy
        | I32GtU ->
            write_byte w 0x4buy
        | I32LeS ->
            write_byte w 0x4cuy
        | I32LeU ->
            write_byte w 0x4duy
        | I32GeS ->
            write_byte w 0x4euy
        | I32GeU ->
            write_byte w 0x4fuy
        | I64Eqz ->
            write_byte w 0x50uy
        | I64Eq ->
            write_byte w 0x51uy
        | I64Ne ->
            write_byte w 0x52uy
        | I64LtS ->
            write_byte w 0x53uy
        | I64LtU ->
            write_byte w 0x54uy
        | I64GtS ->
            write_byte w 0x55uy
        | I64GtU ->
            write_byte w 0x56uy
        | I64LeS ->
            write_byte w 0x57uy
        | I64LeU ->
            write_byte w 0x58uy
        | I64GeS ->
            write_byte w 0x59uy
        | I64GeU ->
            write_byte w 0x5auy
        | F32Eq ->
            write_byte w 0x5buy
        | F32Ne ->
            write_byte w 0x5cuy
        | F32Lt ->
            write_byte w 0x5duy
        | F32Gt ->
            write_byte w 0x5euy
        | F32Le ->
            write_byte w 0x5fuy
        | F32Ge ->
            write_byte w 0x60uy
        | F64Eq ->
            write_byte w 0x61uy
        | F64Ne ->
            write_byte w 0x62uy
        | F64Lt ->
            write_byte w 0x63uy
        | F64Gt ->
            write_byte w 0x64uy
        | F64Le ->
            write_byte w 0x65uy
        | F64Ge ->
            write_byte w 0x66uy
        | I32Clz ->
            write_byte w 0x67uy
        | I32Ctz ->
            write_byte w 0x68uy
        | I32Popcnt ->
            write_byte w 0x69uy
        | I32Add ->
            write_byte w 0x6auy
        | I32Sub ->
            write_byte w 0x6buy
        | I32Mul ->
            write_byte w 0x6cuy
        | I32DivS ->
            write_byte w 0x6duy
        | I32DivU ->
            write_byte w 0x6euy
        | I32RemS ->
            write_byte w 0x6fuy
        | I32RemU ->
            write_byte w 0x70uy
        | I32And ->
            write_byte w 0x71uy
        | I32Or ->
            write_byte w 0x72uy
        | I32Xor ->
            write_byte w 0x73uy
        | I32Shl ->
            write_byte w 0x74uy
        | I32ShrS ->
            write_byte w 0x75uy
        | I32ShrU ->
            write_byte w 0x76uy
        | I32Rotl ->
            write_byte w 0x77uy
        | I32Rotr ->
            write_byte w 0x78uy
        | I64Clz ->
            write_byte w 0x79uy
        | I64Ctz ->
            write_byte w 0x7auy
        | I64Popcnt ->
            write_byte w 0x7buy
        | I64Add ->
            write_byte w 0x7cuy
        | I64Sub ->
            write_byte w 0x7duy
        | I64Mul ->
            write_byte w 0x7euy
        | I64DivS ->
            write_byte w 0x7fuy
        | I64DivU ->
            write_byte w 0x80uy
        | I64RemS ->
            write_byte w 0x81uy
        | I64RemU ->
            write_byte w 0x82uy
        | I64And ->
            write_byte w 0x83uy
        | I64Or ->
            write_byte w 0x84uy
        | I64Xor ->
            write_byte w 0x85uy
        | I64Shl ->
            write_byte w 0x86uy
        | I64ShrS ->
            write_byte w 0x87uy
        | I64ShrU ->
            write_byte w 0x88uy
        | I64Rotl ->
            write_byte w 0x89uy
        | I64Rotr ->
            write_byte w 0x8auy
        | F32Abs ->
            write_byte w 0x8buy
        | F32Neg ->
            write_byte w 0x8cuy
        | F32Ceil ->
            write_byte w 0x8duy
        | F32Floor ->
            write_byte w 0x8euy
        | F32Trunc ->
            write_byte w 0x8fuy
        | F32Nearest ->
            write_byte w 0x90uy
        | F32Sqrt ->
            write_byte w 0x91uy
        | F32Add ->
            write_byte w 0x92uy
        | F32Sub ->
            write_byte w 0x93uy
        | F32Mul ->
            write_byte w 0x94uy
        | F32Div ->
            write_byte w 0x95uy
        | F32Min ->
            write_byte w 0x96uy
        | F32Max ->
            write_byte w 0x97uy
        | F32Copysign ->
            write_byte w 0x98uy
        | F64Abs ->
            write_byte w 0x99uy
        | F64Neg ->
            write_byte w 0x9auy
        | F64Ceil ->
            write_byte w 0x9buy
        | F64Floor ->
            write_byte w 0x9cuy
        | F64Trunc ->
            write_byte w 0x9duy
        | F64Nearest ->
            write_byte w 0x9euy
        | F64Sqrt ->
            write_byte w 0x9fuy
        | F64Add ->
            write_byte w 0xa0uy
        | F64Sub ->
            write_byte w 0xa1uy
        | F64Mul ->
            write_byte w 0xa2uy
        | F64Div ->
            write_byte w 0xa3uy
        | F64Min ->
            write_byte w 0xa4uy
        | F64Max ->
            write_byte w 0xa5uy
        | F64Copysign ->
            write_byte w 0xa6uy
        | I32WrapI64 ->
            write_byte w 0xa7uy
        | I32TruncF32S ->
            write_byte w 0xa8uy
        | I32TruncF32U ->
            write_byte w 0xa9uy
        | I32TruncF64S ->
            write_byte w 0xaauy
        | I32TruncF64U ->
            write_byte w 0xabuy
        | I64ExtendI32S ->
            write_byte w 0xacuy
        | I64ExtendI32U ->
            write_byte w 0xaduy
        | I64TruncF32S ->
            write_byte w 0xaeuy
        | I64TruncF32U ->
            write_byte w 0xafuy
        | I64TruncF64S ->
            write_byte w 0xb0uy
        | I64TruncF64U ->
            write_byte w 0xb1uy
        | F32ConvertI32S ->
            write_byte w 0xb2uy
        | F32ConvertI32U ->
            write_byte w 0xb3uy
        | F32ConvertI64S ->
            write_byte w 0xb4uy
        | F32ConvertI64U ->
            write_byte w 0xb5uy
        | F32DemoteF64 ->
            write_byte w 0xb6uy
        | F64ConvertI32S ->
            write_byte w 0xb7uy
        | F64ConvertI32U ->
            write_byte w 0xb8uy
        | F64ConvertI64S ->
            write_byte w 0xb9uy
        | F64ConvertI64U ->
            write_byte w 0xbauy
        | F64PromoteF32 ->
            write_byte w 0xbbuy
        | I32ReinterpretF32 ->
            write_byte w 0xbcuy
        | I64ReinterpretF64 ->
            write_byte w 0xbduy
        | F32ReinterpretI32 ->
            write_byte w 0xbeuy
        | F64ReinterpretI64 ->
            write_byte w 0xbfuy

