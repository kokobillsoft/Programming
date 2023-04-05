import React, { useState } from 'react';
import { StyleSheet, Text, TextInput, Button, View } from 'react-native';

export default function Form({addHandler}) {
  const [inputTextForList, setValue] = useState('');  
  const onChange = (inputTextForList) => {
    setValue(inputTextForList);
  };
  
    return (
        <View>
            <TextInput style={styles.input} onChangeText={onChange} placeholder='Впишите задачу' clearTextOnFocus="true" />
            <Button color='green' onPress={() => {addHandler(inputTextForList)}} title='add'/>
        </View>
  );
}

const styles = StyleSheet.create({
    input: {
        borderBottomWidth: 1,
        borderColor: 'black',
        padding: 10,
        marginVertical: 30,
        marginHorizontal: '20%',
        width: '60%'
    }
})
